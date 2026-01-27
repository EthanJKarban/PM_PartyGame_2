using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public void OnTutorialButtonClick()
    {
        SceneManager.LoadScene("Tutorial");
    }

}