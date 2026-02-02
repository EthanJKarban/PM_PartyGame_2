using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] public List<GameObject> prefabstoSpawn;
    public float minSpawnInterval = 0;
    public float maxSpawnInterval = 5;
    public float spawnRange = 5f;
    public float SpawnHeight = 5f;
    void Start()
    {
        StartCoroutine(SpawnTime());
    }

    void Update()
    {

        //Vector2 range = new Vector2(spawnRange, SpawnHeight);
        //Vector3 downwardForce = new Vector3(0, -1, 0);

        //spawnInterval += Time.deltaTime;

        //if(spawnInterval > 3)
        //{
        //    Debug.Log("Spawned");
        //    spawnInterval = 0;
        //    GameObject spawnedObject = Instantiate(prefabstoSpawn, range, Quaternion.identity);
        //    //spawnedObject.GetComponent<Rigidbody2D>().AddForce(downwardForce * 5, ForceMode2D.Impulse);
        //}
    }
    
    IEnumerator SpawnTime()
    {
         while (true)
        {
            float randomInterval = UnityEngine.Random.Range(minSpawnInterval, maxSpawnInterval);
            yield return new WaitForSeconds(randomInterval);

            float randomX = UnityEngine.Random.Range(-spawnRange, spawnRange);
            Vector2 spawnPosition = new Vector2(randomX, SpawnHeight);

            int randomIndex = UnityEngine.Random.Range(0, prefabstoSpawn.Count);
            Instantiate(prefabstoSpawn[randomIndex], spawnPosition, Quaternion.identity);
            
        }
    }

}
