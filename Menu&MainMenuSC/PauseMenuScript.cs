using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject PauseMenu;

    public void PauseMenuFun()
    {
        if (Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
            PauseMenu.SetActive(true);
        }
    }

    public void ResumeMenuFun()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            PauseMenu.SetActive(false);
        }
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // Pastikan waktu normal kembali sebelum pindah scene
        SceneManager.LoadScene("MainMenu"); // Panggil scene bernama "MainMenu"
    }

    // Tambahkan method ini untuk berpindah ke scene gameplay dari main menu
    public void LoadGameplayScene()
    {
        Time.timeScale = 1f; // Pastikan waktu normal
        SceneManager.LoadScene("SampleScene"); // Ganti "Gameplay" dengan nama scene gameplay kamu
    }
}
