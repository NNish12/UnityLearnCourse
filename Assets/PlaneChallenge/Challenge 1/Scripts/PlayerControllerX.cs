using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private readonly string Horizontal = "Horizontal";
    private readonly string Vertical = "Vertical";
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] private float speed = 20f;
    [SerializeField] private float rotationSpeed = 3f;


    // Update is called once per frame
    void LateUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis(Vertical);

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * -verticalInput);
    }
}
