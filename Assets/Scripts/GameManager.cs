using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;

    private void Start()
    {
        score = 0;
        UpdateScore(0);

    }

    public void UpdateScore(int scoreToAdd)
    {
       score += scoreToAdd;
       scoreText.text = "Score: " + score;
    }
}
