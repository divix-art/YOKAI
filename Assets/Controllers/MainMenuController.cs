using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    Button btnNewGame;

    [SerializeField]
    Button btnLoadGame;

    [SerializeField]
    Button btnOptions;

    [SerializeField]
    Button btnExit;

    // Start is called before the first frame update 2
    void Start()
    {
        // Assegna i listener agli eventi OnClick dei bottoni
        btnNewGame.onClick.AddListener(NewGame);
        btnLoadGame.onClick.AddListener(LoadGame);
        btnOptions.onClick.AddListener(OpenOptions);
        btnExit.onClick.AddListener(ExitGame);
    }

    // Event handler per il pulsante New Game
    void NewGame()
    {
        Debug.Log("New Game selected");
        // Aggiungi qui il codice per avviare una nuova partita
    }

    // Event handler per il pulsante Load Game
    void LoadGame()
    {
        Debug.Log("Load Game selected");
        // Aggiungi qui il codice per caricare una partita
    }

    // Event handler per il pulsante Options
    void OpenOptions()
    {
        Debug.Log("Options selected");
        // Aggiungi qui il codice per aprire il menu delle opzioni
    }

    // Event handler per il pulsante Exit
    void ExitGame()
    {
        Debug.Log("Exit selected");
        // Aggiungi qui il codice per uscire dal gioco
    }

    // Update is called once per frame
    void Update()
    {

    }
}
