using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void OnCreditsButtonClick()
    {
        SceneManager.LoadScene("Credits");
    }

}