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
    AudioSource grunt;
    AudioSource pop;
    void Start()
    {
        electronCount = 0;
        ui = GameObject.Find("UIupdater").GetComponent<UIupdater>();
        grunt = GameObject.Find("Grunt").GetComponent<AudioSource>();
        pop = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(electronCount == destroyCount){
          pop.time = 0f;
          pop.Play();
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

        grunt.Play();
        ui.health -=damage;
        ui.enemies--;
      }
      // Debug.Log(electronCount);
    }
}
