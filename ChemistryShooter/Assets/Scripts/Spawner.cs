using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{ 
  public GameObject[] enemies;
  public Vector3 spawnValues;
  public float spawnWait;
  public float spawnMostWait;
  public float spawnLeastWait;
  public int startWait;

  public int enemiesAmount;

  int randEnemy;

    // Start is called before the first frame update

    void Start()
    {
      StartCoroutine( waitSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range( spawnLeastWait, spawnMostWait );
    }

    IEnumerator waitSpawner()
    {
      yield return new WaitForSeconds(startWait);

      while( enemiesAmount>0 )
      {
        randEnemy = Random.Range(0, enemies.Length );

        Vector3 spawnPosition = new Vector3( Random.Range( -spawnValues.x, spawnValues.x) , 0.5f, Random.Range( -spawnValues.z, spawnValues.z) );
        // Debug.Log(spawnPosition);
        Instantiate(enemies[randEnemy],  spawnPosition, gameObject.transform.rotation );

        yield return new WaitForSeconds(spawnWait);
        enemiesAmount--;
      }
    }
}
