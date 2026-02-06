using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using System.Collections;

public class RoundWin : MonoBehaviour
{
    public static int PlayersAlive = 1;
    public int WinTimer = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayersAlive = FindObjectsByType<PlayerInput>(FindObjectsInactive.Include, FindObjectsSortMode.None).Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayersAlive == 1)
        {
            EndRound();
        }

    }

    public void EndRound()
    {
        StartCoroutine(WinDelay());
    }

    IEnumerator WinDelay()
    {
        yield return new WaitForSeconds(WinTimer);
        SceneManager.LoadScene("LevelSelect");
    }
}
