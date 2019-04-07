using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("RigidBodyFPSController");
        transform.LookAt(player.transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
    }
}
