using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
