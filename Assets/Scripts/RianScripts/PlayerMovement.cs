using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float damage;
    [SerializeField] private GameObject gun;

   

    [SerializeField] private Animator anim;

    public float speed = 5f;
    public Vector3 offset;
    public Vector2 boxsize;
    public float castDistance;
    private Vector2 movementInput;
    public bool HasDoubleJump = true;
    public GameObject projectilePrefab;
    public Camera mainCamera;

    [SerializeField] private GameObject spawn;



    [SerializeField] private float _jumpForce = 15f;
    private bool jumped = false;
    [SerializeField] private LayerMask _groundLayer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        movementInput = ctx.ReadValue<Vector2>();
        
    }
    public bool IsGrounded()
    {
        if (Physics2D.BoxCast(transform.position + offset, boxsize, 0, -transform.up, castDistance, _groundLayer))
        {
            HasDoubleJump = true;
            return true;

        }
        else
        {
            return false;
        }
    }
    // Update is called once per frame
    private void Update()
    {
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position + offset + Vector3.down * castDistance, boxsize);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            //other.GetComponent<Enemy>().TakeDamage(damage);
            Debug.Log("Enemy hit!");
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocityX = (movementInput.x * speed);

        // Apply velocity in the FixedUpdate for consistent physics interactions (FixedUpdate is called at a fixed interval)
        if (jumped)
        {
            rb.linearVelocityY = _jumpForce;
            jumped = false;
        }
    }

    public void AimGampePad(InputAction.CallbackContext context)
    {
        if (context.ReadValue<Vector2>() != Vector2.zero)
        {
            gun.transform.right = context.ReadValue<Vector2>();
        }

    }

    public void AimMouse(InputAction.CallbackContext context)
    {
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
        gun.transform.right = mousepos - (Vector2)gun.transform.position;
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            GameObject proj = Instantiate(projectilePrefab, spawn.transform.position, Quaternion.identity);
            proj.transform.right = gun.transform.right;
        }
    }

    internal void TakeDamage(int contactDamage)
    {
        throw new NotImplementedException();
    }
    public void Jump(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<float>() == 1)
        {
            if (IsGrounded())
            {
                rb.linearVelocityY = _jumpForce;
                
            }
            if (!IsGrounded())
            {
                if (HasDoubleJump == true)
                {
                    rb.linearVelocityY = _jumpForce;
                    HasDoubleJump = false;
                }
            }
        }
    }
}

