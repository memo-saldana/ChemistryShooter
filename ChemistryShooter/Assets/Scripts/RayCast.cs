﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    
    public Camera cam;
    public GameObject shootingPoint;
    AudioSource suction;
    shoot ammo;
    electron el;
    // Update is called once per frame

    void Start()
    {
      ammo = shootingPoint.GetComponent<shoot>();
      suction = GetComponent<AudioSource>();
      suction.time=0.34f;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
          suction.time=0.34f;
          suction.Play();
          Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
          RaycastHit hit;
          if (Physics.Raycast(ray, out hit))
              print("I'm looking at " + hit.transform.name);
              if(hit.transform.tag=="Element"){
                Debug.Log("ELEMENT");
                el = hit.transform.GetComponent<electron>();
                el.electronCount++;
                ammo.electrons++;

              }
          else
              print("I'm looking at nothing!");
        }
    }
}
