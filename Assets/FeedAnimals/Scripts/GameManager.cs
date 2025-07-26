using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int score = 0;
    private static int lives = 3;
    public static void DecreaseLives()
    {
        lives--;
        CheckLives();
        DisplayLives();

    }
    private static void CheckLives()
    {
        if (lives <= 0)
        {
            lives = 0;
            Debug.Log("GameOver!");
        }
    }
    public static void DisplayLives() => Debug.Log($"Lives = {lives}");
    public static void IncreaseScore()
    {
        score++;
        DisplayScore();
    }
    public static void DisplayScore() => Debug.Log($"Score = {score}");
}
