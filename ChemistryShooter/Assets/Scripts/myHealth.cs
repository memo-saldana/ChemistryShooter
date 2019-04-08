using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myHealth : MonoBehaviour
{
    public int health;
    public int damage;
    // Start is called before the first frame update

    // Update is called once per frame
    void onCollisionEnter(Collision col)
    {
        Debug.Log("PLAYER COLLIDED");
        if(col.gameObject.tag == "Element" && health>0){
          Destroy(col.gameObject);
          health-=damage;
        }
    }
}
