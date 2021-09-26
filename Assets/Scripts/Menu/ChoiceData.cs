using UnityEngine;

[CreateAssetMenu(menuName = "Choice Data")]
public class ChoiceData : ScriptableObject
{    
    public Sprite playerTeam;
    public Sprite enemyTeam;
    public Prediction prediction;
}

public enum Prediction
{ Player, Enemy }
