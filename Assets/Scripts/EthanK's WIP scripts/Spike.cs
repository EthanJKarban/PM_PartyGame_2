using UnityEngine;

public class Spike : MonoBehaviour
{
    public PlayerMovement testSubject;
    public Projectiles1 Potato;

    [Header("Spike Stats")]
    [SerializeField] public int cake = 1;
    [SerializeField] public bool isALie = true;

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            testSubject = collision.gameObject.GetComponent<PlayerMovement>();

            testSubject.health += cake;

            Debug.Log("Oh, it's you. Go away, You took " + cake + " damage");

            if (isALie == true)
            {
                Debug.Log("I'm going to kill you...and all the cake is gone.");
                testSubject.rb.linearVelocityY = (testSubject._jumpForce / 2 + testSubject.health);
                
            }
           
        }
    }

}
 