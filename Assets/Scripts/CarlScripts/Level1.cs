using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    public void OnLV1ButtonClick()
    {
        SceneManager.LoadScene("Level1");
    }

}