using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {


    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadLevelSelectScreen()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadWinScreen()
    {
        SceneManager.LoadScene(5);
    }
    public void LoadGameOverScreen()
    {
        SceneManager.LoadScene(6);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Level1()
    {
        SceneManager.LoadScene(2);
    }
    public void Leve2()
    {
        SceneManager.LoadScene(3);
    }
}
