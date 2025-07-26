using UnityEngine;

public class DodsCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.DecreaseLives();
            Destroy(gameObject);
        }
    }
}
