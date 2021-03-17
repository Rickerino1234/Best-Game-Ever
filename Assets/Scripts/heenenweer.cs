
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heenenweer : MonoBehaviour
{
    public float speed = 1.19f;
    public Vector3 transformatie;
    Vector3 pointB;
    Vector3 cubePos;

    // Start is called before the first frame update
    void Start()
    {
        cubePos = transform.position;
        pointB = new Vector3(cubePos.x + transformatie.x, cubePos.y, cubePos.z + transformatie.z); 
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(cubePos, pointB, time);
    }
}
