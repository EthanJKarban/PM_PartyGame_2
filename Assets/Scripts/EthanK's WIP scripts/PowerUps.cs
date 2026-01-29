using System.Collections;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public PU powerUp;
    public PS playerStats;
    public Player Playa;
    public GameObject pickupEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        // Add the buff here and it will wait for seconds before cancelling it
        if(powerUp.isABuff == true)
        {
          Playa.speed *= powerUp.speedMultiplier;
          //Playa.damage *= powerUp.powerMultiplier;

        }
        if(powerUp.isAHeal == true)
        {
            // This then would heal
        }
        if(powerUp.isAAbility == true)
        {
            // This would give an ability
        }

        yield return new WaitForSeconds(powerUp.buffDuration);

        //When this wait for seconds ends the buff will end here 
        if(powerUp.speedMultiplier != 1)
        {
            powerUp.speedMultiplier = 1;
            playerStats.speed = 5f;
        }
        if(Playa.speed != 5f)
        {
            Playa.speed = 5f;
        }
        //if(powerUp.powerMultiplier != 1)
        //{
        //    powerUp.powerMultiplier = 1;
        //    playerStats.power = 3f;

        //}
        //if(powerUp.defenseMultiplier != 1)
        //{
        //    powerUp.defenseMultiplier = 1;
        //    playerStats.defense = 0f;
        //}

        Destroy(gameObject);
    }
}
