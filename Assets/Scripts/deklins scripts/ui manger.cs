using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class uimanger : MonoBehaviour
{
    public List<GameObject> uis;
    private List<GameObject> players = new();

    public void join(PlayerInput input)
    {
        players.Add(input.gameObject);
        uis[input.playerIndex].SetActive(true);
    }

    public void leave(PlayerInput input)
    {
        players.Remove(input.gameObject);
        uis[input.playerIndex].SetActive(false);
    }
}
