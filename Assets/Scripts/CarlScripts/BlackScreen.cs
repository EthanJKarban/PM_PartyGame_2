using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackScreen : MonoBehaviour
{
    public float delayBeforeLoad = 3f;

    void Start()
    {
        Invoke(nameof(LoadNextScene), delayBeforeLoad);
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene("Quit");
    }
}
