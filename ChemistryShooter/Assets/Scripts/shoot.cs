﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shoot : MonoBehaviour
{
  public int electrons;
  
  public Rigidbody bala;
  public float speed;
  Rigidbody clone;

  void Start()
  {
    
  }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0) && electrons>0){
            clone=Instantiate(bala,transform.position,transform.rotation);
            clone.velocity=transform.TransformDirection(0,0,-speed);
            electrons--;
            Destroy(clone.gameObject,2);
        }
    }
}
