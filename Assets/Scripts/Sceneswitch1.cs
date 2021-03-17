using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneswitch1 : MonoBehaviour
{
    public int Level;
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(Level);
    }
}
