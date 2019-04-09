using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    ammo.text = "Oxygens: "+shootPoint.GetComponent<shoot>().electrons;
    if(health>0){
      healthText.text = "Health: "+health;
    } else {
      SceneManager.LoadScene("GameOver");
    
    }
    if(enemies>0){
      enemiesHUD.text = "Enemies Left: "+enemies; 
    } else {
      SceneManager.LoadScene("Win");
     
    }

  }

}