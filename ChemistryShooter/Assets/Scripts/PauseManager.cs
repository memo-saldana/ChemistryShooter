using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

// Code from unity3d.com tutorials
public class PauseManager : MonoBehaviour {
    
    Canvas canvas;
    
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }
    public void Pause()
    {
        if(canvas.enabled){
          Time.timeScale = 1;
          Cursor.visible = false;
          Cursor.lockState = CursorLockMode.Locked;
          canvas.enabled = false;
        } else {
          Time.timeScale = 0;
          Cursor.visible = true;
          Cursor.lockState = CursorLockMode.None;
          canvas.enabled = true;
        }
    }
    
    public void Quit()
    {
        #if UNITY_EDITOR 
        EditorApplication.isPlaying = false;
        #else 
        Application.Quit();
        #endif
    }
}