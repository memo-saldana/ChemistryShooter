using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstToPlay : MonoBehaviour
{
    public void GotoStarScene()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void GotoMainGameScene()
    {
        SceneManager.LoadScene("MainGame");
    }
}
