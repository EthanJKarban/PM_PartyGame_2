using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    public void OnBackButtonClick()
    {
        SceneManager.LoadScene("MainMenu");
    }

}