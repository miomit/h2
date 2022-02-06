using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class playerCircle : MonoBehaviour
{
    public GM gm;

    public AudioSource obstaclesAudio;
    public AudioSource scoreAudio;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "score"){
            scoreAudio.Play();
            gm.Score++;
        }

        if (collision.tag == "obstacles")
        {
            obstaclesAudio.Play();
            gm.gameObject.GetComponent<Game>().Replay = true;
        }
    }
}
