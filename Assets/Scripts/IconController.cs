using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IconController : MonoBehaviour
{

    public void LoadOpening()
    {
        Debug.Log("Opening scene");
        SceneManager.LoadScene(0); 
    }

    public void LoadText()
    {
        Debug.Log("Text scene");
        SceneManager.LoadScene(1); 
    }

    public void LoadWar()
    {
        Debug.Log("War scene");
        SceneManager.LoadScene(2); 
    }

    public void LoadMap()
    {
        Debug.Log("Map scene");
        SceneManager.LoadScene(3); 
    }

}
