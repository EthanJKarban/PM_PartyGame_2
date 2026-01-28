using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    [SerializeField] private ParticleSystem dieParticle = default;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Out of bounds! Destroying player.");
        collision.gameObject.CompareTag("Player");
        Instantiate(dieParticle, collision.transform.position, Quaternion.identity);
        Destroy(collision.gameObject);
        Destroy(dieParticle, 2f);
    }
        
    
}
