using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public Game game;

    public Text GameScore;
    public Text MenuScore;

    public string GameScoreStr { 
        get => GameScore.text;
        set
        {
            GameScore.text = value;
        }
    }

    private int score = 0;

    public int Score
    {
        get => score;
        set
        {
            GameScore.text = value.ToString();
            if (game.StartGame) MenuScore.text = value.ToString();
            score = value;
        }
    }
}
