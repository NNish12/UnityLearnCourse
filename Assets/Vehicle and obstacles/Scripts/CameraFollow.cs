
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public PlayerController player1;
    private PlayerController currentView;
    private Vector3 offset;
    private Vector3 nearOffset;
    private Vector3 tempOffset;
    private void Start()
    {
        currentView = player1;
        offset = transform.position;
        nearOffset = new Vector3(0f, 2f, 0.5f);
        tempOffset = offset;
    }
    void LateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            ChangeCameraVeiw();
        }
        transform.position = currentView.transform.position + tempOffset;

    }
    private void ChangeCameraVeiw()
    {
        if (tempOffset == offset)
        {
            tempOffset = nearOffset;
        }
        else
        {
            tempOffset = offset;
        }
    }
}
