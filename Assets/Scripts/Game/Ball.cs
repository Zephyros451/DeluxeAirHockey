using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    private float maxSpeed = 10f;

    private Vector2 playerPosition = new Vector2(0f, -2.1f);
    private Vector2 enemyPosition = new Vector2(0f, 2.1f);

    private void FixedUpdate()
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
    }

    public void PlaceToPlayerSide()
    {
        transform.position = playerPosition;
        rb.velocity = Vector2.zero;
    }

    public void PlaceToEnemySide()
    {
        transform.position = enemyPosition;
        rb.velocity = Vector2.zero;
    }

    public void StopBall()
    {
        rb.velocity = Vector2.zero;
    }
}
