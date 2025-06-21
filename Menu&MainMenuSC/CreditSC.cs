using UnityEngine;

public class CreditPanelController : MonoBehaviour
{
    public GameObject creditPanel;
    public AudioSource mainMenuAudio;
    public AudioSource creditAudio;

    public void ShowCredits()
    {
        creditPanel.SetActive(true);

        if (mainMenuAudio.isPlaying)
            mainMenuAudio.Pause();

        if (!creditAudio.isPlaying)
            creditAudio.Play();
    }

    public void HideCredits()
    {
        creditPanel.SetActive(false);

        if (creditAudio.isPlaying)
            creditAudio.Stop();

        if (!mainMenuAudio.isPlaying)
            mainMenuAudio.Play();
    }
}
