using UnityEngine;
using Managers;

public class LogoScreenController : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameManager.Instance.sceneManager.LoadScene(GameManager.Instance.sceneManager.SceneNames.SplashScreen);
        }
    }
}
