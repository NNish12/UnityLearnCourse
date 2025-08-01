using UnityEngine;

public class DestroySteak : MonoBehaviour
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
            Destroy(this.gameObject);
        }
    }
}
