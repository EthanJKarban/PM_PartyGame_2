using System.Collections;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField] public float selfDestroyTime = 10f;
    [SerializeField] public float countdown;
    public PU powerUp;
    //public PS playerStats;
    public PlayerMovement Playa;
    public GameObject pickupEffect;

    public void Awake()
    {
        Playa = FindFirstObjectByType<PlayerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") == true)
        {
            
            Playa.StartCoroutine(Pickup(other));
        }
    }

    private void Update()
    {
        countdown += Time.deltaTime;
        if(countdown >= selfDestroyTime)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        //Instantiate(pickupEffect, transform.position, transform.rotation);

        // Add the buff here and it will wait for seconds before cancelling it
        if(powerUp.isABuff == true)
        {
          Playa.speed *= powerUp.speedMultiplier;
          Playa.reloadTimer /= powerUp.ReloadcooldownMultiplier;
          Playa._jumpForce *= powerUp.jumpForceMultiplier;
            //Playa.damage *= powerUp.powerMultiplier;

        }
        if(powerUp.isAHeal == true)
        {
            // This then would heal
            Playa.health += powerUp.healAmount;
        }
        if(powerUp.isAAbility == true)
        {
            // This would give an ability
        }
        
        GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(powerUp.buffDuration);

        //When this wait for seconds ends the buff will end here 

        if(Playa.speed >= powerUp.maxSpeed)
        {
            Playa.speed = powerUp.maxSpeed;
        }
        if(Playa.reloadTimer <= powerUp.maxReloadTimer)
        {
          Playa.reloadTimer = powerUp.maxReloadTimer;
        }
        if(Playa._jumpForce >= powerUp.maxJumpForce)
        {
            Playa._jumpForce = powerUp.maxJumpForce;
        }
        if(Playa.health <= powerUp.minimumHealth)
        {
            Playa.health = powerUp.minimumHealth;
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
