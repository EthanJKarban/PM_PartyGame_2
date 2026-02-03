using JetBrains.Annotations;
using UnityEngine;

[CreateAssetMenu(fileName = "New Buff", menuName = "Player Buff")]

public class PU : ScriptableObject
{
    [Header("Buff Stats")]
    [SerializeField] public float buffDuration = 3f;
    [SerializeField] public float speedMultiplier = 1f;
    [SerializeField] public float powerMultiplier = 1f;
    [SerializeField] public float defenseMultiplier = 1f;
    [SerializeField] public float jumpForceMultiplier = 1.1f;
    [SerializeField] public float ReloadcooldownMultiplier = 1.2f;
    [SerializeField] public float healAmount;
    [SerializeField] public bool isABuff = true;
    [SerializeField] public bool isAHeal;
    [SerializeField] public bool isAAbility;
    [SerializeField] public float maxSpeed = 13.4f;
    [SerializeField] public float maxReloadTimer = 0.25f;
    [SerializeField] public float maxJumpForce = 30f;
    





}
