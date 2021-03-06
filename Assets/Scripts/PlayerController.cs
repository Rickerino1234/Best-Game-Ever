﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Scene scene;
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    bool isKlaar;
    int[] AantalMunten = { 0, 0, 5, 6, 8, 5 };
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;

    void Start()
    {
 
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        scene = SceneManager.GetActiveScene();
        int BuildIndex = scene.buildIndex;

        countText.text = "Coins: " + count.ToString();
        if(count == AantalMunten[BuildIndex])
        {
            winTextObject.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        if (isKlaar == true && scene.buildIndex == 5)
        {
            SceneManager.LoadScene(0);
        }
        if (isKlaar == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            isKlaar = false;
            count = 0;
        }
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
       
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        scene = SceneManager.GetActiveScene();
        int BuildIndex = scene.buildIndex;
        Debug.Log(AantalMunten[BuildIndex]);
        if (count == AantalMunten[BuildIndex])
        {
            if(other.gameObject.CompareTag("NieuweLevel"))
            {
                isKlaar = true;
            }
        }


        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }
    }
}