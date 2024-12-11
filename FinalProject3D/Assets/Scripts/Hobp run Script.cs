using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HobprunScript : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player triggered the object
        if (other.CompareTag("Player"))
        {
            // Load the specified scene
            SceneManager.LoadScene(9);
        }
    }

    }
