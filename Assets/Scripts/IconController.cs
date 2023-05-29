using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IconController : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        Debug.Log("Play method called");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back()
    {
        Debug.Log("Back method called");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


  
}
