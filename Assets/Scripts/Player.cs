using UnityEngine;

public class Player : MonoBehaviour
{
    public Game game;
    public GM gm;

    public float SpeedRotate { get => 2f + (gm.Score / 100); }

    public bool isLeft = false;

    private void FixedUpdate()
    {
        if (game.StartGame)
        {
            if (isLeft) transform.rotation *= Quaternion.Euler(0f, 0f, SpeedRotate);
            else transform.rotation *= Quaternion.Euler(0f, 0f, -SpeedRotate);
        }
    }

    public void ClickButton()
    {
        if (game.StartGame)
            isLeft = !isLeft;
        else
            if (!game.Replay) game.StartGame = true;
    }
}
