using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RunScene3 : MonoBehaviour
{
    public Button loadSceneButton;



    public void OnButtonClick()
    {
        Random.Range(0, 2);
        int chance = Random.Range(0, 2);
        if (chance == 0)
        {
            SceneManager.LoadScene(5);
        }
        else if (chance == 1)
        {
            SceneManager.LoadScene(14);
        }

    }

}
