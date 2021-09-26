using UnityEngine;

[CreateAssetMenu(menuName = "Score Data")]
public class ScoreData : ScriptableObject
{
    public int playerScore;
    public int enemyScore;

    public void Restart()
    {
        playerScore = 0;
        enemyScore = 0;
    }
}
