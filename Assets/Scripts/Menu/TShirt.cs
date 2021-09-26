using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TShirt : MonoBehaviour
{
    [SerializeField] private Image ball;
    [SerializeField] private Image shirt;
    [SerializeField] private TShirt anotherTShirt;
    [SerializeField] private Button chooseButton;

    private void OnEnable()
    {
        chooseButton.interactable = false;
    }

    public void Select()
    {
        chooseButton.interactable = true;
        ball.enabled = true;
        anotherTShirt.UnSelect();
    }

    public void UnSelect()
    {
        ball.enabled = false;
    }

    public void SetShirt(Sprite sprite)
    {
        shirt.sprite = sprite;
    }
}
