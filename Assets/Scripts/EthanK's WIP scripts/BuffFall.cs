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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
           
           if(rb != null)
           {
                Debug.Log("AAAAAAAAAAAAAAAA");
                rb.linearVelocity = Vector2.zero;
                rb.bodyType = RigidbodyType2D.Kinematic;
                rb.constraints = RigidbodyConstraints2D.FreezeAll;
           }
        }
    }
}
