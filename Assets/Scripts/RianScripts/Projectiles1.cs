using UnityEngine;

public class Projectiles1 : MonoBehaviour
{
    private Rigidbody2D rb;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = transform.right * 10f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.gameObject.CompareTag("Ground"))
        {
           
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);
        }


    }

}

