using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int totalScore = 0;
    public int targetScore = 10;

    public TextMeshProUGUI TotalScoreText;
    public GameObject winPanel;

    private void Start()
    {
        UpdateScoreUI();

        if (winPanel != null)
            winPanel.SetActive(false);
    }

    public void AddScore(int amount)
    {
        totalScore += amount;
        UpdateScoreUI();

        if (totalScore >= targetScore)
        {
            EndGame();
        }
    }

    private void UpdateScoreUI()
    {
        TotalScoreText.text = "Score: " + totalScore + " / " + targetScore;
    }

    private void EndGame()
    {
        Time.timeScale = 0f;
        if (winPanel != null)
            winPanel.SetActive(true);
    }
}
