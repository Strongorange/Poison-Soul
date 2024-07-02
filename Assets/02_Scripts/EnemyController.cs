using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public enum Type
    {
        Orc
    }

    public Type enemyType;
    public Rigidbody2D target;
    public Rigidbody2D rigid;
    public BoxCollider2D boxCollider;
    public SpriteRenderer spriteRenderer;

    public int maxHealth;
    public int currentHealth;
    public float speed;
    public bool isChase;
    public bool isAttack;
    public bool isDead;

    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (isDead)
        {
            return;
        }

        Vector2 dirVec = target.position - rigid.position;
        Vector2 nextVec = dirVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);

        rigid.velocity = Vector2.zero;
    }

    void LateUpdate()
    {
        spriteRenderer.flipX = target.position.x < rigid.position.x;
    }

    // Update is called once per frame
    void Update() { }
}
