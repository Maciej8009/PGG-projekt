using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    
    public void RestartGame()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("SampleScene");
    }
}
