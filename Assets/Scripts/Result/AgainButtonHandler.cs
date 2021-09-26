using UnityEngine;

public class AgainButtonHandler : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.instance.LoadMainMenuScene();
        AudioPlayer.instance.UnPauseBackground();
    }
}
