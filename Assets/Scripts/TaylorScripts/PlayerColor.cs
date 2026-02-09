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
        playerRenderer = GetComponent<SpriteRenderer>();

        if (playerRenderer == null)
        {
            Debug.LogError("Player prefab needs a Renderer component!");
        }

        // Find the gun renderer (pivot -> gun) so we can color it too
        Transform pivotTransform = transform.Find("pivot");
        if (pivotTransform != null)
        {
            Transform gunTransform = pivotTransform.Find("gun");
            if (gunTransform != null)
            {
                gunRenderer = gunTransform.GetComponent<SpriteRenderer>();
                if (gunRenderer == null)
                    Debug.LogWarning("Found 'gun' but it has no SpriteRenderer.");
            }
        }

        Color color = new Color();
        int idx = 0;
        if (playerInput != null && playerInput.user != null)
            idx = playerInput.user.index;

        switch (idx)
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

        if (playerRenderer != null)
            playerRenderer.color = color;

        if (gunRenderer != null)
            gunRenderer.color = color;
    }
}
