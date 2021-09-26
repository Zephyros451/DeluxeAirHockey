using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Game : MonoBehaviour
{
    [SerializeField] private Gate playerGate;
    [SerializeField] private Gate enemyGate;
    [SerializeField] private Score score;
    [SerializeField] private ChoiceData choiceData;
    [SerializeField] private Player player;
    [SerializeField] private Enemy enemy;
    [SerializeField] private Ball ball;
    
    private void OnEnable()
    {
        playerGate.Goal += OnPlayerGoal;
        enemyGate.Goal += OnEnemyGoal;
    }

    private void OnPlayerGoal()
    {
        player.Immobilize();
        enemy.Immobilize();
        DOTween.Sequence()
            .AppendCallback(ball.StopBall)
            .AppendInterval(1.5f)
            .AppendCallback(() =>
            {
                score.PointToEnemy();
                player.PlaceInStartPosition();
                enemy.PlaceInStartPosition();                
            })
            .AppendInterval(0.1f)
            .AppendCallback(ball.PlaceToPlayerSide)
            .AppendInterval(0.4f)
            .AppendCallback(()=>
            {
                player.Mobilize();
                enemy.Mobilize();
            });
    }

    private void OnEnemyGoal()
    {
        player.Immobilize();
        enemy.Immobilize();
        DOTween.Sequence()
            .AppendCallback(ball.StopBall)
            .AppendInterval(1.5f)
            .AppendCallback(() =>
            {
                score.PointToPlayer();
                player.PlaceInStartPosition();
                enemy.PlaceInStartPosition();
                ball.PlaceToEnemySide();
            })
            .AppendInterval(0.1f)
            .AppendCallback(ball.PlaceToEnemySide)
            .AppendInterval(0.4f)
            .AppendCallback(() =>
            {
                player.Mobilize();
                enemy.Mobilize();
            });
    }
}
