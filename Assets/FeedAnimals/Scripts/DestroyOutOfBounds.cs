using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound = 30f;
    [SerializeField] private float bottomBound = -10f;
    [SerializeField] private float leftBound = -20f;
    [SerializeField] private float rigthBound = 20f;

    private void Update()
    {
        if (transform.position.z > topBound) Remove();
        else if (transform.position.z < bottomBound) Remove();
        else if (transform.position.x < leftBound) Remove();
        else if (transform.position.x > rigthBound) Remove();
    }
    private void Remove()
    {
        GameManager.DecreaseLives();
        Destroy(this.gameObject);
    }

}
