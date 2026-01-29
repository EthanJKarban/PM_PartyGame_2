using System;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] public GameObject prefabstoSpawn;
    public float spawnInterval = 0;
    public float spawnRange;
    public float SpawnHeight;
    void Start()
    {
        
    }

    void Update()
    {

        Vector2 range = new Vector2(spawnRange, SpawnHeight);
        Vector3 downwardForce = new Vector3(0, -1, 0);

        spawnInterval += Time.deltaTime;

        if(spawnInterval > 3)
        {
            Instantiate(prefabstoSpawn, range, Quaternion.identity);
            spawnInterval = 0;
            GameObject spawnedObject = Instantiate(prefabstoSpawn, range, Quaternion.identity);
            spawnedObject.GetComponent<Rigidbody2D>().AddForce(downwardForce * 5, ForceMode2D.Impulse);
        }
    }
    

}
