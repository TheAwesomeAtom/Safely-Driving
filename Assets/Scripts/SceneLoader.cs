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
        SceneManager.LoadScene("Questions");
        Debug.Log("Click!");
    }
}