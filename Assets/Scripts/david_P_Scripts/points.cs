using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class points : MonoBehaviour
{
    public float pointsAmount;
    public float pointsToWin = 3f;
    public TextMeshProUGUI pointsText;
    public void Awake()
    {
       

    }

    private void Update()
    {
        var players = FindObjectsByType<movment>(FindObjectsSortMode.None);

        if (players.Length <= 1)
        {
            AddPoints(1);
            EndGame();
        }
        pointsText.text = "Points: " + pointsAmount.ToString();
    }

    
    public void AddPoints(float pointsToAdd)
    {
        pointsAmount += pointsToAdd;
        Debug.Log("Points: " + pointsAmount);
    }


    public void EndGame()
    {
        
        if(pointsAmount >= pointsToWin)
        {
            Debug.Log("You Win!");
            //SceneManager.LoadScene("WinScreen");
        }
    }
}
