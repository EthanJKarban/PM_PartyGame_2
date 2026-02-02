using UnityEngine;

public class BuffFall : MonoBehaviour
{
    private Rigidbody2D rb;


    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
           
           if(rb != null)
           {
                
                rb.linearVelocity = Vector2.zero;
                rb.bodyType = RigidbodyType2D.Kinematic;
           }
        }
    }
}
