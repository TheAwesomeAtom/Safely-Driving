using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Click!");
    }
    public void AboutUs()
    {
        SceneManager.LoadScene("AboutUs");
        Debug.Log("Click!");
    }
    public void Questions()
    {
        SceneManager.LoadScene("QSetSelect");
        Debug.Log("Click!");
    }

    public void RoadConditions()
    {
        SceneManager.LoadScene("RoadConditions");
        Debug.Log("Click!");
    }

    public void RCQ1()
    {
        SceneManager.LoadScene("RCQ1");
        Debug.Log("Click!");
    }
}