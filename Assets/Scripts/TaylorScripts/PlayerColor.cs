using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 
using UnityEngine.UIElements;

public class PlayerColor : MonoBehaviour
{
    private SpriteRenderer playerRenderer;
    private SpriteRenderer gunRenderer;
    private PlayerInput playerInput;

    [SerializeField] private List<Color> playerColors = new List<Color>();


    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        // Replace the GetComponentInChildren line with this:
        playerRenderer = GetComponent<SpriteRenderer>();


            if (playerRenderer == null)
        {
            Debug.LogError("Player prefab needs a Renderer component!");
        }

        Color color = new Color();
        switch (playerInput.user.index)
        {
            case 0:
                color = playerColors[0];
                break;

            case 1:
                color = playerColors[1];

                break;

            case 2:
                color = playerColors[2];
                break;

            case 3:
                color = playerColors[3];
                break;
        }
        color.a = 1f;
        playerRenderer.color = color;
    }
    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();

        // Find "pivot", then find "g u n" inside it
        Transform pivotTransform = transform.Find("pivot");
        if (pivotTransform != null)
        {
            Transform gunTransform = pivotTransform.Find("gun");
            if (gunTransform != null)
            {
                gunRenderer = gunTransform.GetComponent<SpriteRenderer>();
            }
        }
    }
}
