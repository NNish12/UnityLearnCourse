using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private readonly string Horizontal = "Horizontal";
    private readonly string Vertical = "Vertical";
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] private float speed = 20f;
    [SerializeField] private float turnSpeed = 3f;

    private void Update()
    {
        horizontalInput = Input.GetAxis(Horizontal);
        verticalInput = Input.GetAxis(Vertical);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
    public float GetHorizontalInput() => horizontalInput;

}
