using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    GameObject player;
    Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("RigidBodyFPSController");
        rb = GetComponent<Rigidbody>();
        transform.LookAt(player.transform);
        rb.velocity = transform.TransformDirection(0,0,speed);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        rb.velocity = transform.TransformDirection(0,0,speed);
    }
}
