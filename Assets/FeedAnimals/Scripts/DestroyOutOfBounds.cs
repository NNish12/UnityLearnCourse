using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound = 30f;
    [SerializeField] private float bottomBound = -10f;
    private void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(this.gameObject);
        }
        else if (transform.position.z < bottomBound)
        {
            Debug.Log("Game Over!");
            Destroy(this.gameObject);
        }
    }
}
