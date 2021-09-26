using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private ChoiceData choiceData;
    [SerializeField] private ScoreData scoreData;

    [Space, SerializeField] private Image player;
    [SerializeField] private Image enemy;
    [SerializeField] private Text playerScore;
    [SerializeField] private Text enemyScore;

    private void OnEnable()
    {
        scoreData.Restart();

        player.sprite = choiceData.playerTeam;
        enemy.sprite = choiceData.enemyTeam;
        playerScore.text = scoreData.playerScore.ToString();
        enemyScore.text = scoreData.enemyScore.ToString();
    }

    public void PointToPlayer()
    {
        scoreData.playerScore++;
        playerScore.text = scoreData.playerScore.ToString();
    }

    public void PointToEnemy()
    {
        scoreData.enemyScore++;
        enemyScore.text = scoreData.enemyScore.ToString();
    }
}
