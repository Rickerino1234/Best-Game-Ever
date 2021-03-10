using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heenenweer : MonoBehaviour
{
    public float speed = 1.19f;
    Vector3 pointA;
    Vector3 pointB;
    public Vector3 cubePos;

    // Start is called before the first frame update
    void Start()
    {
        cubePos = transform.position;
        pointA = new Vector3(7, 0, 3); //Begincoordinaten
        pointB = new Vector3(cubePos.x - 1, cubePos.y, cubePos.z - 1); //eincoordinaten
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(cubePos, pointB, time);
    }
}
