using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    [SerializeField]
    Object SplashScreen;

    [SerializeField]
    Object MainMenuScene;

    public void ToSplashScreen ()
    {
        SceneManager.LoadScene(SplashScreen.name);
    }

    public void ToMainMenuScreen ()
    {
        SceneManager.LoadScene(MainMenuScene.name);
    }
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
