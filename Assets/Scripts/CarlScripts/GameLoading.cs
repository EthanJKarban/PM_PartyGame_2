using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoading : MonoBehaviour
{
    public float delayBeforeLoad = 8f;

    void Start()
    {
        Invoke(nameof(LoadNextScene), delayBeforeLoad);
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
