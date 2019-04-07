using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detector : MonoBehaviour
{
    // Start is called before the first frame update

    RaycastHit hit;
    Ray rayo;

    // Draw the Ray in RED
    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(rayo.origin, rayo.direction * 10, Color.red );
        rayo =  Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(rayo,out hit)){
          print("I see a: "+ hit.transform.name);
        } else {
          print("I see nothing, nothing :c");
        }
    }
}
