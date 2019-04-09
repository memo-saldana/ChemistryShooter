using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; 
#if UNITY_EDITOR
#endif
public class ButtonQuit : MonoBehaviour
{
    public void Quit()
    {
        #if UNITY_EDITOR 
        EditorApplication.isPlaying = false;
        #else 
        Application.Quit();
        #endif
    }
}
