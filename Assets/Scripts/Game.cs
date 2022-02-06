using Unity.VisualScripting;
using UnityEngine;

public class Game : MonoBehaviour
{
    private bool startGame = false;
    public bool StartGame { 
        get => startGame; 
        set {
            startGame = value;
            if (value) GetComponent<GM>().Score = 0;
        } 
    }

    public Animator animScreen;

    private bool replay = false;
    public bool Replay
    { 
        get => replay;
        set
        {
            if (value)
            {
                StartGame = false;
                animScreen.SetTrigger("isDown");
            }
            else
            {
                animScreen.SetTrigger("isUp");
            }

            replay = value;
        }
    }
}
