
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public PlayerController player1;
    public PlayerController player2;
    private PlayerController currentView;
    private Vector3 offset;
    private Vector3 nearOffset;
    private Vector3 tempOffset;
    [SerializeField] private float speedCameraRotate = 15f;
    private void Start()
    {
        currentView = player1;
        offset = transform.position;
        nearOffset = new Vector3(0f, 2f, 0.5f);
        tempOffset = offset;
    }
    void LateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            ChangeVehicle();
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            ChangeCameraVeiw();
        }
        transform.position = currentView.transform.position + tempOffset;
        transform.RotateAround(currentView.transform.position, Vector3.up, currentView.GetHorizontalInput() * Time.deltaTime * speedCameraRotate);

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
    private void ChangeVehicle()
    {
        if (currentView == player1)
        {
            SetActivePlayer(player2, player1);
        }
        else
        {
            SetActivePlayer(player1, player2);
        }

    }
    private void SetActivePlayer(PlayerController activePlayer, PlayerController inactivePlayer)
    {
        activePlayer.enabled = true;
        inactivePlayer.enabled = false;
        currentView = activePlayer;
    }

}
