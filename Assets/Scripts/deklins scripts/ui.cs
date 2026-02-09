using UnityEngine;

public class ui : MonoBehaviour
{
    public PlayerMovement player;
    public int player1;
    public int player2;
    public int player3;
    public int player4;
    public TMPro.TMP_Text jumpforcetext;
    public TMPro.TMP_Text knockbacktext;
    public TMPro.TMP_Text reloadTimertext;
    //public TMPro.TMP_Text knockbackimmuntext;
    public TMPro.TMP_Text healthtext;
    public TMPro.TMP_Text speedtext;
    void Update()
    {
        
        /// Update the UI text elements with the current values
        jumpforcetext.text = "jumpforce: " + player._jumpForce;
        reloadTimertext.text = "Firerate: " + player.reloadTimer;
        //knockbackimmuntext.text = "Knockback Immune: " + palyer.;
        speedtext.text = "Speed: " + player.speed;
        healthtext.text = "Heal: " + player.health;
    }
}
