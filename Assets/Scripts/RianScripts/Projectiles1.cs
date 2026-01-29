using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;

public class Projectiles1 : MonoBehaviour
{
    private Collider2D col;
    private Rigidbody2D rb;

    public float knockback;
    public float speed;
    public float lifetime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        col = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();

        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = transform.right * speed;
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
            Knockback();
        }

        Vector3 point = collision.ClosestPoint(transform.position);
        Vector2 difference = (transform.position - point).normalized;

        Vector2 launchangle = difference * knockback;

        collision.attachedRigidbody.linearVelocity = launchangle;

    }

        void Knockback()
    {

    }
}

