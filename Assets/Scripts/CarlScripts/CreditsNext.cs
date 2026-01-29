using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsNext : MonoBehaviour
{
    public void OnNextButtonClick()
    {
        SceneManager.LoadScene("CarlCredits");
    }

}