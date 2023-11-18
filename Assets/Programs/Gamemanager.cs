using System;
using System.Collections;
using System.Collections.Generic;

using Unity.VisualScripting;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public GameObject player;
    public float speed;



    // Start is called before the first frame update
    void Start()
    {
        speed = 0.5f;


    }
    void Update()
    {
        float nowX = player.transform.position.x;
        float nowZ = player.transform.position.z;
        float nowY = player.transform.position.y;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.position = new Vector3(nowX - speed, nowY, nowZ);
            Debug.Log("向左觸發成功");
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("向右觸發成功");
            player.transform.position = new Vector3(nowX + speed, nowY, nowZ);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("向前觸發成功");
            player.transform.position = new Vector3(nowX, nowY, nowZ + speed);

        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("向後觸發成功");
            player.transform.position = new Vector3(nowX, nowY, nowZ - speed);
        }
    }

}

// Update is called once per frame
