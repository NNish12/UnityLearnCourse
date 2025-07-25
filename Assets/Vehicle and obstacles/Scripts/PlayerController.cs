using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private readonly string Horizontal = "Horizontal";
    private readonly string Vertical = "Vertical";
    [SerializeField] private float speed = 20f;
    [SerializeField] private float turnSpeed = 3f;
    private float horizontalInput;
    private float verticalInput;
    void Update()
    {
        horizontalInput = Input.GetAxis(Horizontal);
        verticalInput = Input.GetAxis(Vertical);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
