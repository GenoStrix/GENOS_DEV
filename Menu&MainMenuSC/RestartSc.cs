using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void Restart()
    {
        Time.timeScale = 1f; // pastikan waktu jalan lagi
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
