using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    public int epicScore = 0;
    public int rareScore = 0;

    public ScoreManager scoreManager; // Tambahkan ini

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CollectibleItem item = collision.GetComponent<CollectibleItem>();

        if (item != null)
        {
            int value = item.GetScoreValue();

            switch (item.itemType)
            {
                case CollectibleItem.ItemType.Epic:
                    epicScore += value;
                    break;
                case CollectibleItem.ItemType.Rare:
                    rareScore += value;
                    break;
            }

            // Tambahkan skor ke total
            if (scoreManager != null)
            {
                scoreManager.AddScore(value);
            }

            Destroy(collision.gameObject);
        }
    }
}
