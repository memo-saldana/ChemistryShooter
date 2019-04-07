using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
   public Rigidbody bala;
   public float speed;
   Rigidbody clone;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            clone=Instantiate(bala,transform.position,transform.rotation);
            clone.velocity=transform.TransformDirection(0,0,-speed);
            Destroy(clone.gameObject,2);
        }
    }
}
