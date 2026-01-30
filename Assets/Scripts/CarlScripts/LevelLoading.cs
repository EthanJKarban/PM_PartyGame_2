using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoading : MonoBehaviour
{
    public float delayBeforeLoad = 10f;

    void Start()
    {
        Invoke(nameof(LoadNextScene), delayBeforeLoad);
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene("");
    }
}
