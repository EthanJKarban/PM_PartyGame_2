using JetBrains.Annotations;
using UnityEngine;

[CreateAssetMenu(fileName = "New Buff", menuName = "Player Buff")]

public class PU : ScriptableObject
{
    [Header("Buff Stats")]
    [SerializeField] public float buffDuration = 3f;
    [SerializeField] public float speedMultiplier = 1f;
    [SerializeField] public float powerMultiplier = 1f;
    [SerializeField] public float defenseMultiplier;
    [SerializeField] public float cooldownMultiplier;
    [SerializeField] public float healAmount;
    [SerializeField] public bool isABuff = true;
    
    



}
