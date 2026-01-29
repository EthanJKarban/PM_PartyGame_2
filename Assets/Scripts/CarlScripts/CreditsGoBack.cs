using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsGoBack : MonoBehaviour
{
    public void OnArrowButtonClick()
    {
        SceneManager.LoadScene("Credits");
    }

}