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
    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<TrailRenderer>();
    }


    protected override void Ability()
    {
        StartCoroutine(Dash());
    }

    IEnumerator Dash()
    {
        canUse = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.linearVelocity = new Vector2(transform.localScale.x * dashPower, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingtime);
        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(cooldownTime);
        canUse = true;
    }
}
