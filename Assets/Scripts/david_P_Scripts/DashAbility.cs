using UnityEngine;
using UnityEngine.InputSystem;

public class DashAbility : AbilityBase
{
    public AbilityBase AbilityBase;
    private Vector2 dashInput;

    public void Dash(InputAction.CallbackContext ctx)
    {
        dashInput = ctx.ReadValue<Vector2>();
    }

    protected override void Ability()
    {
        
       
        // Implement the logic to activate the dash ability
        Debug.Log("Dash ability activated!");
        // You can add your dash logic here, such as increasing player speed temporarily
    }

}
