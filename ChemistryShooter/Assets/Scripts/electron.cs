using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class electron : MonoBehaviour
{
    // Start is called before the first frame update
    public int destroyCount;
    public int damage;
    public int electronCount;
    public Text label;
    public string labelname;
    UIupdater ui;
    void Start()
    {
        electronCount = 0;
        ui = GameObject.Find("UIupdater").GetComponent<UIupdater>();
    }

    // Update is called once per frame
    void Update()
    {
        if(electronCount == destroyCount){
          Debug.Log("Destroyed");
          Destroy(gameObject);
          ui.enemies--;
        }
        label.text = electronCount == 0? labelname: electronCount>0? labelname+ '+'+ electronCount: labelname+electronCount;
    }

    void OnCollisionEnter(Collision col){
      Debug.Log("Collided " + col.gameObject.name);
      
      if(col.gameObject.name == "Bullet(Clone)"){
        electronCount--;
        Destroy(col.gameObject);
      } else if( col.gameObject.name == "RigidBodyFPSController"){
        Destroy(gameObject);
        ui.enemies--;
        ui.health -=damage;
      }
      // Debug.Log(electronCount);
    }
}
