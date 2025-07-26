
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private readonly string Horizontal = "Horizontal";
    private readonly string Vertical = "Vertical";
    [SerializeField] private float speed = 30f;
    [SerializeField] private float xRange = 15f;
    [SerializeField] private float zTop = 15f;
    [SerializeField] private float zBotton = 7f;
    [SerializeField] private GameObject projectilePrefab;
    private float horizontalInput;
    private float verticalInput;

    private void Start()
    {
        GameManager.DisplayScore();
        GameManager.DisplayLives();
    }
    private void Update()
    {
        horizontalInput = Input.GetAxis(Horizontal) * speed * Time.deltaTime;
        verticalInput = Input.GetAxis(Vertical) * speed * Time.deltaTime;
        transform.Translate(new Vector3(horizontalInput, 0f, verticalInput));
        Vector3 pos = transform.position;

        if (pos.x < -xRange) pos.x = -xRange;
        if (pos.x > xRange) pos.x = xRange;
        if (pos.z < -zBotton) pos.z = -zBotton;
        if (pos.z > zTop) pos.z = zTop;

        transform.position = pos;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, pos, projectilePrefab.transform.rotation);
        }
    }
}
