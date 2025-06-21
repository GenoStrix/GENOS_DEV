using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // player
    public float smoothSpeed = 0.125f;

    public Vector2 minPosition; // batas kiri bawah
    public Vector2 maxPosition; // batas kanan atas

    void LateUpdate()
    {
        if (target == null)
            return;

        // Dapatkan posisi target (player)
        Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z);

        // Clamp posisi kamera agar tidak keluar dari batas
        float clampedX = Mathf.Clamp(desiredPosition.x, minPosition.x, maxPosition.x);
        float clampedY = Mathf.Clamp(desiredPosition.y, minPosition.y, maxPosition.y);

        Vector3 clampedPosition = new Vector3(clampedX, clampedY, desiredPosition.z);

        // Smooth follow
        transform.position = Vector3.Lerp(transform.position, clampedPosition, smoothSpeed);
    }
}
