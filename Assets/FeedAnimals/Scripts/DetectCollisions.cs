using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other != null && other.tag != "Player")
        {
            Destroy(gameObject);
        }
    }
}
