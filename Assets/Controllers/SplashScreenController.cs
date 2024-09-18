using UnityEngine;
using Managers;

public class SplashScreenController : MonoBehaviour
{

    public void ToMainMenuScreen()
    {
        GameManager.Instance.sceneManager.LoadScene(GameManager.Instance.sceneManager.SceneNames.MainMenuScene);
    }
}