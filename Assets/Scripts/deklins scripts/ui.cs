using UnityEngine;

public class ui : MonoBehaviour
{
    public bool knockback;
    public bool firerate;
    public bool knockbackimmune;
    public GameObject[] players = new GameObject[4];

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Canvas.ForceUpdateCanvases();
    }

    // Update is called once per frame
    void Update()
    {
        if (players.Length < 4) 
            { 
            if (players[0] == null) {
                players[0] = GameObject.Find("player1");
            }
            if (players[1] == null)
            {
                players[1] = GameObject.Find("player2");
            }
            if (players[2] == null)
            {
                players[2] = GameObject.Find("player3");
            }
            if (players[3] == null)
            {
                players[3] = GameObject.Find("player4");
            }
        }
    }
}
