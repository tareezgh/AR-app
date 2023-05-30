using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IconController : MonoBehaviour
{
    public void Play()
    {
        Debug.Log("Main scene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back()
    {
        Debug.Log("Secondary scene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


  
}
