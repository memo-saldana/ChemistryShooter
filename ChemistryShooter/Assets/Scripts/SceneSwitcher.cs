using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneSwitcher : MonoBehaviour
{
    void Awake()
    {
      Time.timeScale = 1;
      Cursor.lockState = CursorLockMode.None;
      Cursor.visible= true;

    }
    public void GotoStartScene()
    {
        SceneManager.LoadScene("Start");
    }

    public void GotoCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }

    public void GotoMainGameScene()
    {
      Debug.Log("Change to game");
        SceneManager.LoadScene("MainGame");
    }

    public void GotoInstructionsScene()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void GotoWinScene()
    {
        SceneManager.LoadScene("Win");
    }
}
