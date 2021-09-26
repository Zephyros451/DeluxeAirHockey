using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;   

    private float sensitivity = 20;
    private Vector2 startPosition = new Vector2(0, -4.2f);
    private bool canMove = true;

    private Vector2 previousPosition;
    private Vector2 newPosition;

    private Vector2 bottomRightCorner;
    private Vector2 borders;

    private void Awake()
    {
        bottomRightCorner = new Vector2(Screen.width, 0);
        bottomRightCorner = Camera.main.ScreenToWorldPoint(bottomRightCorner);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && canMove)
        {
            newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            newPosition = new Vector2(Mathf.Clamp(newPosition.x, -bottomRightCorner.x, bottomRightCorner.x),
                                      Mathf.Clamp(newPosition.y, bottomRightCorner.y, 0));
            newPosition = Vector2.Lerp(rb.position, newPosition, Time.deltaTime * sensitivity);

            rb.MovePosition(newPosition);
        }
        previousPosition = transform.position;
    }

    public void PlaceInStartPosition()
    {
        rb.MovePosition(startPosition);
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
