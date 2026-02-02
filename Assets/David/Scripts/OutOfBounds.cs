using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    [SerializeField] private ParticleSystem dieParticle = default;

    public PlayerMovement _player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //_player.isDead = true;


        /*Debug.Log("Out of bounds! Destroying player.");
        collision.gameObject.CompareTag("Player");
        Instantiate(dieParticle, collision.transform.position, Quaternion.identity);
        Destroy(collision.gameObject);
        Destroy(dieParticle, 2f);
        */
    }
        
    
}
