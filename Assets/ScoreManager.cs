using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;  // Attach your UI Text element here for displaying score

    void Start()
    {
        // Initialize the score display
        UpdateScoreText();
    }

    // Method to increase score by a specified amount
    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    // Update the score text UI
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
