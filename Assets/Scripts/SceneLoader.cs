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

    public void Signs()
    {
        SceneManager.LoadScene("Signs");
        Debug.Log("Click!");
    }
    
    public void BCC()
    {
        SceneManager.LoadScene("BCC");
        Debug.Log("Click!");
    }

    public void RoadEtiquette()
    {
        SceneManager.LoadScene("RoadEtiquette");
        Debug.Log("Click!");
    }

    public void NextQ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Correct!");
    }
    
    public void PreviousQ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("Click!");
    }
}