using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
            Destroy(other.gameObject);
        Destroy(this.gameObject);

    }
}
