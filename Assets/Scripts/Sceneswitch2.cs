using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneswitch2 : MonoBehaviour
{
    private int count;
    void start()
    {
        count = 0;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
        }

        if (count >= 5)
        {
            SceneManager.LoadScene(3);
        }
    }
}
