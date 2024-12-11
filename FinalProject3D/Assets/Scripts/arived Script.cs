using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class arivedScript : MonoBehaviour
{
    public Button loadSceneButton;



    // This function is called when the button is clicked
    public void OnButtonClick()
    {
        if (PointScript.lateness < 3)
        {
            SceneManager.LoadScene(12);
        }
        else if (PointScript.lateness >= 3)
        {
            SceneManager.LoadScene(13);
        }



    }
}
