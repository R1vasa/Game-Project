using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour
{
    public static ScoreLogic Instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    private int currentScore = 0;
    private int highScore = 0;

    private void Awake()
    {
        if (Instance = null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateUI();
    }

    public void AddScore(int points)
    {
        currentScore += points;

        if (currentScore > highScore)
        {
            highScore = currentScore;

            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + currentScore;
        }
        if (highScoreText != null)
        {
            highScoreText.text = "High Score: " + highScore;
        }
    }

    public void ResetHighScore()
    {
        highScore = 0;
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
        UpdateUI();
    }
}
