using UnityEngine;

public class Projectiles : MonoBehaviour
{
    private Rigidbody2D rb;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 5f);
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
        Debug.Log("i hit the ground");
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("i died");
            Destroy(gameObject);
        }


    }
}

