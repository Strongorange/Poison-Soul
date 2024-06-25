using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float hAxis;
    public float vAxis;
    protected Vector3 moveVec;

    void Update()
    {
        GetInput();
        Move();
    }

    void Move()
    {
        moveVec = new Vector3(hAxis, vAxis, 0);
        transform.position += moveVec * moveSpeed * Time.deltaTime;
    }

    protected abstract void GetInput();
}
