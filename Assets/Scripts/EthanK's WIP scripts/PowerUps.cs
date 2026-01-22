using System.Collections;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public PU powerUp;
    public PS playerStats;
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
        yield return new WaitForSeconds(powerUp.buffDuration);

        //When this wait for seconds ends the buff will end here 
        if(powerUp.speedMultiplier != 1)
        {
            powerUp.speedMultiplier = 1;
            playerStats.speed = 5f;
        }
        if(powerUp.powerMultiplier != 1)
        {
            powerUp.powerMultiplier = 1;
            playerStats.power = 3f;
            
        }
        if()

        Destroy(gameObject);
    }
}
