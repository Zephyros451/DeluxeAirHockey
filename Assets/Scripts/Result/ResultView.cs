using UnityEngine;
using UnityEngine.UI;

public class ResultView : MonoBehaviour
{
    [SerializeField] private ScoreData scoreData;
    [SerializeField] private ChoiceData choiceData;
    [SerializeField] private Sprite[] resultVariants;

    [Space, SerializeField] private Image result;
    [SerializeField] private Image playerImage;
    [SerializeField] private Image enemyImage;
    [SerializeField] private Text playerScore;
    [SerializeField] private Text enemyScore;

    private void OnEnable()
    {
        if (scoreData.playerScore > scoreData.enemyScore && choiceData.prediction == Prediction.Player ||
            scoreData.enemyScore > scoreData.playerScore && choiceData.prediction == Prediction.Enemy)
        {
            result.sprite = resultVariants[0];
            AudioPlayer.instance.PlayWin();
        }
        else
        {
            result.sprite = resultVariants[1];
            AudioPlayer.instance.PlayLose();
        }

        playerImage.sprite = choiceData.playerTeam;
        enemyImage.sprite = choiceData.enemyTeam;

        playerScore.text = scoreData.playerScore.ToString();
        enemyScore.text = scoreData.enemyScore.ToString();
    }
}
