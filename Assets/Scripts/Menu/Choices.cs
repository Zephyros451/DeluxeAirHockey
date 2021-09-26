using UnityEngine;
using UnityEngine.UI;

public class Choices : MonoBehaviour
{
    [SerializeField] private ChoiceData data;

    public void ChooseTeam(Image image)
    {
        data.playerTeam = image.sprite;
    }

    public void SetEnemy(Image image)
    {
        data.enemyTeam = image.sprite;
    }

    public void MakePrediction(bool win)
    {
        if(win)
        {
            data.prediction = Prediction.Player;
        }
        else
        {
            data.prediction = Prediction.Enemy;
        }
    }
}
