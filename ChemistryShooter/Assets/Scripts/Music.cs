using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource audioSource;
    private static Music _instance;

    public static Music Instance { get; private set; }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
 
     public void PlayMusic()
     {
         if (audioSource.isPlaying) return;
         audioSource.Play();
     }
 
     public void StopMusic()
     {
         audioSource.Stop();
     }
}
