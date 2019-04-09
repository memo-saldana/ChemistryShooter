using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneSwitcher : MonoBehaviour
{
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
