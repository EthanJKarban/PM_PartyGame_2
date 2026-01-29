using UnityEngine;
using System;
using Unity.VisualScripting;

[CreateAssetMenu(fileName = "item", menuName = "Scriptable Objects/item")]
public class item : ScriptableObject
{

    private Rigidbody2D _rb;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           // Destroy(this.gameObject);
        }
    }
}
