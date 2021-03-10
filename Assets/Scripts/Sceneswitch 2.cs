using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneswitch2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       
        if (count >= 5)
        {
            SceneManager.LoadScene(3);
        }
    }
}
