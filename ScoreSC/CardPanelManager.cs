using UnityEngine;

public class CardPanelManager : MonoBehaviour
{
    public static CardPanelManager Instance;

    [Tooltip("List panel yang sesuai dengan setiap item.")]
    public GameObject[] tutorialPanels;

    private bool[] hasPicked = new bool[2];

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
    }
    

    // Fungsi dipanggil oleh item saat disentuh

    public void OnItemPicked(CollectibleItem.ItemType itemType)
    {
        int index = (int)itemType;

        if (!hasPicked[index])
        {
            ShowTutorialPanel(index);
            hasPicked[index] = true;
        }
    }

    private void ShowTutorialPanel(int index)
    {
        // Cek apakah index valid
        if (index < 0 || index >= tutorialPanels.Length)
        {
            Debug.LogWarning("Index panel di luar batas array: " + index);
            return;
        }

        GameObject panel = tutorialPanels[index];
        if (panel != null)
        {
            panel.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("Menampilkan panel: " + panel.name);
        }
        else
        {
            Debug.LogWarning("Panel pada index " + index + " adalah null!");
        }
    }


    public void HideAllPanels()
    {
        foreach (var panel in tutorialPanels)
        {
            if (panel != null) panel.SetActive(false);
        }

        Time.timeScale = 1f;
    }

    public void ResetItemState()
    {
        hasPicked = new bool[2]; 
        HideAllPanels(); // Juga sembunyikan semua panel saat reset
    }

    public void OnCloseTutorialButton()
    {
        HideAllPanels();
    }
}
