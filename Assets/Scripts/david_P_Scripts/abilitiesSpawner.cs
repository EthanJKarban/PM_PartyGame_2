using NUnit.Framework;
using System.Collections;
using UnityEngine;

public class abilitiesSpawner : MonoBehaviour
{
    
    [HideInInspector] public float xpos;
    [HideInInspector] public float ypos;
    public float totalAbilities;
    public float abilityChance;
    public float rand = 15f;
    public float awayFromPlayer;

    public float spawntime;
    public float spawnDelay;

    private void Start()
    {
        var abilityTypes = FindObjectsByType<abilitiesSpawner>(FindObjectsSortMode.None);
        StartCoroutine(spawnNewAbility());
    }

    IEnumerator spawnNewAbility()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawntime);
            xpos = Random.Range(-rand, rand);
            ypos = Random.Range(-rand, rand);
            Vector2 abilityPos = new Vector2(xpos, ypos);
            float distanceFromPlayer = Vector2.Distance(abilityPos, GameObject.FindGameObjectWithTag("Player").transform.position);
            if (distanceFromPlayer >= awayFromPlayer)
            {
                
            }
        }
    }
}
