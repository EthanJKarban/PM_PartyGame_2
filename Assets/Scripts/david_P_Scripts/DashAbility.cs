using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DashAbility : AbilityBase
{
    private bool isDashing;  
    public float dashPower;
    public float dashingtime;
    public Rigidbody2D rb;
    public TrailRenderer tr;
    public PlayerMovement playerMovement;
    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<TrailRenderer>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    protected override void Ability()
    {
        StartCoroutine(Dash());
    }

    IEnumerator Dash()
    {
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        playerMovement.enabled = false; // Disable player movement during dash
        rb.linearVelocity = new Vector2(playerMovement.direction * dashPower, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingtime);
        playerMovement.enabled = true; // Re-enable player movement after dash
        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
    }
}
