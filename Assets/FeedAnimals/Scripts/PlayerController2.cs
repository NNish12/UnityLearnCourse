using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private readonly string Horizontal = "Horizontal";
    [SerializeField] private float speed = 30f;
    [SerializeField] private float xRange = 15f;
    [SerializeField] private GameObject projectilePrefab;
    private float horizontalInput;

    private void Update()
    {
        horizontalInput = Input.GetAxis(Horizontal);
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
