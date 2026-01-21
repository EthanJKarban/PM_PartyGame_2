using System.Collections;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public PU powerUp;
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
        yield return new WaitForSeconds(0.2f);

        //When this wait for seconds ends the buff will end here 

        Destroy(gameObject);
    }
}
