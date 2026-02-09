using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLoader : MonoBehaviour
{
    public PlayerInputManager inputManager;

    void Awake()
    {
        int i = 0;

        foreach (var item in InputSystem.devices)
        {
            if (item is Keyboard||item is Gamepad)
            {
                inputManager.JoinPlayer(i++, pairWithDevice: item);
            }
           
        }
    }
}
