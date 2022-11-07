using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;
    [SerializeField] private int highScore;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("Score");
        highScoreText.text = "Highscore: " + highScore.ToString();
    }
    private void Update()
    {
        score = Mathf.RoundToInt(player.transform.position.x - transform.position.x);
        scoreText.text = "Score: " + score.ToString();
    }

    public void End()
    {
        if (score > highScore)
        {
            highScore = score;
            highScoreText.text = "Highscore: " + highScore.ToString();
            PlayerPrefs.SetInt("Score", highScore);
            PlayerPrefs.Save();
        }

    }
}
