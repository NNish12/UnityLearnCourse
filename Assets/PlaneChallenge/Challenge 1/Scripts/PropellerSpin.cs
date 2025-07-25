using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 50f;
    void Update()
    {
        transform.Rotate(Vector3.forward * rotateSpeed);
    }
}
