using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject pet;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwapPositions();
        }
    }

    void SwapPositions()
    {
        Vector3 tempPlayerpos = player.transform.position;
        player.transform.position = pet.transform.position;
        pet.transform.position = tempPlayerpos;
    }
}
