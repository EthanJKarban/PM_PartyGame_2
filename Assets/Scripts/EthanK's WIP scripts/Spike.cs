using UnityEngine;

public class Spike : MonoBehaviour
{
    public PlayerMovement testSubject;

    [Header("Spike Stats")]
    [SerializeField] public int cake;
    [SerializeField] public bool isALie;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            testSubject = collision.gameObject.GetComponent<PlayerMovement>();

            testSubject.health -= cake;

            if (isALie)
            {
                //testSubject.rb.linearVelocityY = testSubject._jumpForce;
            }
           
        }
    }

}
