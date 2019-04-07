using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{ 
  public GameObject[] enemies;
  [SerializeField] private Vector3 spawnValues;
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
        randEnemy = Random.Range(0, enemies.Length )

        Vector3 spawnPosition = new Vector3( Random.Range( -spawnValues.x, spawnValues.x) , 1, Random.Range( -spawnValues.z, spawnValues.z) );

        Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint( 0, 0, 0 ), gameObject.transform.rotation );

        yield return new WaitForSeconds(spawnWait);
        enemiesAmount--;
      }
    }
}
