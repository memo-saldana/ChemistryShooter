using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    public int destroyCount;
    private int electronCount;
    void Start()
    {
        electronCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(electronCount == destroyCount){
          Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision col){
      if(col.gameObject.name == "Bullet(Clone)"){
        electronCount++;
        Destroy(col.gameObject);
      }
      Debug.Log(electronCount);
    }
}
