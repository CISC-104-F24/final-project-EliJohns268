using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GotAwayScript : MonoBehaviour
{
    public Button loadSceneButton;



    // This function is called when the button is clicked
    public void OnButtonClick()
    {
        // Replace "NewScene" with the name of your scene, make sure it matches the Build Settings name
        SceneManager.LoadScene(10);



    }
}