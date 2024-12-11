using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Scene5Run : MonoBehaviour
{
    public Button loadSceneButton;



    // This function is called when the button is clicked
    public void OnButtonClick()
    {
        Random.Range(0, 2);
        int chance = Random.Range(0, 2);
        if (chance == 0)
        {
            PointScript.lateness--;
            SceneManager.LoadScene(7);
        }
        else if (chance == 1)
        {
            SceneManager.LoadScene(14);
        }


    }

}
