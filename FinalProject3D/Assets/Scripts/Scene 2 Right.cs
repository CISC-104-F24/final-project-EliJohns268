using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene2Script : MonoBehaviour
{
    public Button loadSceneButton;

    void Start()
    {
        // Check if the button is assigned in the Inspector
        if (loadSceneButton != null)
        {
            // Add the listener to the button
            loadSceneButton.onClick.AddListener(OnButtonClick);
        }
        else
        {
            Debug.LogError("Button is not assigned!");
        }
    }

    // This function is called when the button is clicked
    public void OnButtonClick()
    {
        // Replace "NewScene" with the name of your scene, make sure it matches the Build Settings name
        SceneManager.LoadScene(4);
    }


}
