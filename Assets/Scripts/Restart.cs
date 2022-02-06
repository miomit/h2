using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject[] Obstacles;
    public GameObject player;
    public GameObject score;

    public AudioSource ReplayAudio;

    public Game game;

    public void ButtonClick()
    {
        ReplayAudio.Play();

        foreach (GameObject obs in Obstacles)
        {
            obs.transform.localPosition = new Vector2(obs.transform.localPosition.x, 0.88f);
            obs.GetComponent<Obstacles>().isUp = false;
        }

        score.transform.rotation = Quaternion.identity;
        player.transform.rotation = Quaternion.identity;
        player.GetComponent<Player>().isLeft = false;
        game.GetComponent<GM>().Score = 0;
        game.Replay = false;
    }
}
