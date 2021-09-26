using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Rigidbody2D ball;

    private Vector2 startPosition = new Vector2(0, 4.2f);
    private float sensitivity = 4f;
    private bool canMove = true;

    private Vector2 previousPosition;
    private Vector2 newPosition;
    private bool shouldAttack = true;
    private bool shouldGetBack;

    private void Update()
    {
        if (canMove)
        {
            if (ball.position.y > 0 && shouldAttack)
            {
                newPosition = Vector2.Lerp(rb.position, ball.position, Time.deltaTime * sensitivity);
                rb.MovePosition(newPosition);
            }

            if (shouldGetBack)
            {
                newPosition = Vector2.Lerp(rb.position, startPosition, Time.deltaTime * (sensitivity - 2));
                rb.MovePosition(newPosition);
            }

            previousPosition = transform.position;
        }
    }

    private IEnumerator Behaviour()
    {
        yield return new WaitForSeconds(0.2f);
        shouldAttack = false;
        shouldGetBack = true;
        yield return new WaitForSeconds(1f);
        shouldAttack = true;
        shouldGetBack = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(shouldAttack == true)
        {
            StartCoroutine(Behaviour());
        }
    }

    public void PlaceInStartPosition()
    {
        transform.position = startPosition;
    }

    public void Immobilize()
    {
        canMove = false;
    }

    public void Mobilize()
    {
        canMove = true;
    }
}
