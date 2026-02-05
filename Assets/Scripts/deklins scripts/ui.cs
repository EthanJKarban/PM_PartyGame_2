using UnityEngine;

public class ui : MonoBehaviour
{
    public int player1;
    public int player2;
    public int player3;
    public int player4;
    public int knockback;
    public int firerate;
    public int knockbackimmune;
    public TMPro.TMP_Text knockbacktext;
    public TMPro.TMP_Text fireratetext;
    public TMPro.TMP_Text knockbackimmuntext;
    void Update()
    {
        /// Update the UI text elements with the current values
        knockbacktext.text = "Knockback: " + knockback;
        fireratetext.text = "Firerate: " + firerate;
        knockbackimmuntext.text = "Knockback Immune: " + knockbackimmune;

    }
}
