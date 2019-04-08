using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIupdater : MonoBehaviour 
{
  
  public Text enemiesHUD;
  public GameObject spawner;
  Spawner enemyData;
  public GameObject shootPoint;
  
  public int enemies;

  public Text ammo;
  public GameObject HealthObject;
  public int health;
  public Text healthText;

  void Start()
  {
    enemyData = spawner.GetComponent<Spawner>();
    enemies = enemyData.enemiesAmount;
  }

  void Update()
  {
    ammo.text = "Electrons: "+shootPoint.GetComponent<shoot>().electrons;
    if(enemies>0){

      enemiesHUD.text = "Enemies Left: "+enemies; 
    } else {
      enemiesHUD.text = "No more enemies left.";
    }
    healthText.text = "Health: "+health;

  }

}