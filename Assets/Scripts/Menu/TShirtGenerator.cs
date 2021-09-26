using System.Collections.Generic;
using UnityEngine;

public class TShirtGenerator : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private TShirt[] shirts;
    [SerializeField] private ChoiceData data;

    private List<Sprite> notUsedSprites;

    public void GenerateTeamChoice()
    {
        notUsedSprites = new List<Sprite>(sprites);
        for (int i = 0; i < 4; i++)
        {
            int index = Random.Range(0, notUsedSprites.Count);
            shirts[i].SetShirt(notUsedSprites[index]);
            notUsedSprites.Remove(notUsedSprites[index]);
        }        
    }

    public void GeneratePrediction()
    {
        shirts[4].SetShirt(data.playerTeam);

        int index = Random.Range(0, notUsedSprites.Count);
        shirts[5].SetShirt(notUsedSprites[index]);
        data.enemyTeam = notUsedSprites[index];
        notUsedSprites.Remove(notUsedSprites[index]);
    }
}
