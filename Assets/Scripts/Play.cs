using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public AudioSource PlayAudio;
    public void ButtonClick()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        PlayAudio.Play();
        yield return new WaitForSeconds(0.7f);
        SceneManager.LoadScene("Game");
    }
}
