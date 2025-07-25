using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public PlayerController player1;
    public PlayerController player2;
    private PlayerController currentView;
    private Vector3 offset;
    private void Start()
    {
        currentView = player1;
        offset = transform.position;

    }
    void LateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            ChangeVehicle();
        }
        transform.position = currentView.transform.position + offset;
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
