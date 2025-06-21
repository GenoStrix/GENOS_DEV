using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    public GameObject loadingPanel; // Panel loading dari UI

    public void StartGame()
    {
        StartCoroutine(LoadGameScene());
    }

    IEnumerator LoadGameScene()
    {
        // Tampilkan UI loading
        loadingPanel.SetActive(true);

        // Jeda selama 5 detik sebelum load scene
        yield return new WaitForSeconds(5f);

        // Load scene secara async
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("SampleScene");

        // Tunggu hingga scene selesai dimuat
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void QuitGame()
    {
        Debug.Log("Game quit!");
        Application.Quit();
    }
}
