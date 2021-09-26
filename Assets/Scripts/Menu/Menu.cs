using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject start;
    [SerializeField] private GameObject chooseTeam;
    [SerializeField] private GameObject prediction;

    private void OnEnable()
    {
        ShowStart();
    }

    public void ShowStart()
    {
        start.SetActive(true);
        chooseTeam.SetActive(false);
        prediction.SetActive(false);
    }

    public void ShowChooseTeam()
    {
        start.SetActive(false);
        chooseTeam.SetActive(true);
        prediction.SetActive(false);
    }

    public void ShowPrediction()
    {
        start.SetActive(false);
        chooseTeam.SetActive(false);
        prediction.SetActive(true);
    }

    public void LoadGame()
    {
        SceneManager.instance.LoadGameScene();
    }
}
