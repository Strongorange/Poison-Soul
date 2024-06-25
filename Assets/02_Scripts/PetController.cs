using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetController : BasePlayerController
{
    protected override void GetInput()
    {
        // 매 프레임마다 Axis 초기화 하지 않으면 키보드에서 떼도 계속 움직임
        hAxis = 0;
        vAxis = 0;

        if (Input.GetKey(KeyCode.W))
        {
            vAxis = 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            hAxis = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vAxis = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            hAxis = -1;
        }
    }
}
