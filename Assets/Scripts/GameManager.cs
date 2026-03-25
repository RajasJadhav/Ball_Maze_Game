using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;
    public Button startButton;

    public GameObject titleScreen;
    public GameObject gameOverScreen;

    private int score;
    private float time;
    public bool isGameActive;

    private void Start()
    {
        

    }

    private void Update()
    {
        UpdateTime();
    }

    public void StartGame()
    {
        score = 0;
        time = 60;
        isGameActive = true;
        UpdateScore(0);
        titleScreen.SetActive(false);
    }

    public void UpdateScore(int scoreToAdd)
    {
       score += scoreToAdd;
       scoreText.text = "Score: " + score;
    }

    public void UpdateTime()
    {
        if(isGameActive)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
            }
            time = Mathf.Max(time , 0);
            timeText.text = "Time: " + Mathf.FloorToInt(time).ToString();

            if (time <= 0)
            {
                GameOver();
            }
        }
            
        
    } 
    
    public void GameOver()
    {
        isGameActive = false;
        gameOverScreen.SetActive(true);

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
