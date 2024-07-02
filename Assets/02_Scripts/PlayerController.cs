using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BasePlayerController
{
    public Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigid.velocity = Vector2.zero;
    }

    protected override void GetInput()
    {
        // 매 프레임마다 Axis 초기화 하지 않으면 키보드에서 떼도 계속 움직임
        hAxis = 0;
        vAxis = 0;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            vAxis = 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            hAxis = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vAxis = -1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            hAxis = -1;
        }
    }
}
