using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseScript : MonoBehaviour
{
    public string sceneToQuitOn = "Quit";
    public float quitDelay = 1f;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == sceneToQuitOn)
        {
            StartCoroutine(QuitGameAfterDelay(quitDelay));
        }
    }

    IEnumerator QuitGameAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        QuitGame();
    }

    public void QuitGame()
    {
        Debug.Log("Quitting application...");

        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
