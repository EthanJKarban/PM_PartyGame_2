using UnityEngine;

public class QuitSimple : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void QuitGame()
    {
        Debug.Log("Quitting application...");
        Application.Quit();
    }
}
