using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public enum ItemType { Epic, Rare }
    public ItemType itemType;

    public GameObject CardPanel; // Panel khusus item ini

    public int GetScoreValue()
    {
        switch (itemType)
        {
            case ItemType.Epic: return 10;
            case ItemType.Rare: return 50;
            default: return 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            

            Destroy(gameObject);
        }
    }
}
