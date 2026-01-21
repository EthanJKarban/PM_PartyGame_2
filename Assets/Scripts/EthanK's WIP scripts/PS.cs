using System;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "Player Stats")]

public class PS : ScriptableObject
{
    // This is not gonna be the main thing probably but it just helps me visualize the player stats and etc
    [Header("Player Stats")]
    [SerializeField] public float knockback = 0;
    [SerializeField] public float speed = 5;
    [SerializeField] public float defense = 0;
    [SerializeField] public float power = 0.5f;
    [SerializeField] public float cooldown = 1;

    [Header("Player Attributes")]
    [SerializeField] public bool isDead;
    [SerializeField] public bool isEquipped;
    [SerializeField] public bool isWinner = false;
    [SerializeField] public PU[] pu;



}
