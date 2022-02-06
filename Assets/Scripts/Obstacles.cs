using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public Transform GmUp, GmDown;

    public float Speed = 10, SpeedRotate = 2f;

    public bool isUp = false;

    public Game game;

    private void Update()
    {
        if (transform.position == GmUp.position || transform.position == GmDown.position) isUp = !isUp;
    }

    private void FixedUpdate()
    {
        if (game.StartGame)
        {
            if (isUp) transform.position = Vector3.MoveTowards(transform.position, GmUp.position, Speed * Time.deltaTime);
            else transform.position = Vector3.MoveTowards(transform.position, GmDown.position, Speed * Time.deltaTime);
            transform.rotation *= Quaternion.Euler(0f, 0f, SpeedRotate);
        }
    }
}
