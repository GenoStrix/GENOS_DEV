using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public AudioClip pickupSound; // ← Tambahkan field untuk suara
    private AudioSource audioSource;

    private void Start()
    {
        // Tambahkan komponen AudioSource jika belum ada
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CollectibleItem item = GetComponent<CollectibleItem>();
            if (item != null && CardPanelManager.Instance != null)
            {
                CardPanelManager.Instance.OnItemPicked(item.itemType);
            }

            // Putar suara pickup jika tersedia
            if (pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }

            Destroy(gameObject); // Hapus objek setelah dipungut
        }
    }
}
