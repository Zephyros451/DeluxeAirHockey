using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderPlacer : MonoBehaviour
{
    [SerializeField] Transform top;
    [SerializeField] Transform bottom;
    [SerializeField] Transform left;
    [SerializeField] Transform right;

    [SerializeField] Transform topLeft;
    [SerializeField] Transform topRight;

    private Vector2 topRightCorner;

    private void Awake()
    {
        topRightCorner = new Vector2(Screen.width, Screen.height);
        topRightCorner = Camera.main.ScreenToWorldPoint(topRightCorner);

        top.position = new Vector3(0, topRightCorner.y, 0);
        bottom.position = new Vector3(0, -topRightCorner.y, 0);
        left.position = new Vector3(-topRightCorner.x, 0, 0);
        right.position = new Vector3(topRightCorner.x, 0, 0);

        topLeft.position = new Vector3(-topRightCorner.x * 0.75f, topRightCorner.y, 0);
        topRight.position = new Vector3(topRightCorner.x * 0.75f, topRightCorner.y, 0);
    }
}
