using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Game game;
    public Transform score;

    private int min = 1, max = 3;

    private int scoreRotate = 0, oldScoreRotate;
    public int ScoreRotate
    {
        get => scoreRotate;
        set
        {
            if (game.StartGame)
            {
                oldScoreRotate = scoreRotate;
                scoreRotate = value;

                if (oldScoreRotate == scoreRotate) scoreRotate++;
            }
            else
            {
                scoreRotate = value;
            }

            score.Rotate(0f, 0f, 90 * scoreRotate);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ScoreRotate = Random.Range(min, max);
        }
    }
}
