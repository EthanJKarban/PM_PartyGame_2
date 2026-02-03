using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    public PlayerMovement _player;

    private void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {


        Debug.Log("Out of bounds! Destroying player.");
        collision.gameObject.CompareTag("Player");
        _player = collision.gameObject.GetComponent<PlayerMovement>();
        _player.isDead = true;
        
    }
        
    
}
