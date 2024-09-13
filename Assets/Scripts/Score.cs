using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{


    public static Score instance;

    [SerializeField] private Text scoreText;
    [SerializeField] private Text highScoreText;

    int score = 0;
    int highscore = 0;


    private void Awake()
    {
        instance = this;
    }



    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore",0);
        scoreText.text = score.ToString() + " " + "POINTS";
        highScoreText.text = "HIGHSCORE:" + highscore.ToString();
    }



     public void AddScore()

     {
        score += 1;
        scoreText.text = score.ToString() + "  " + "POINTS";
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
     }

     


   
}
