using UnityEngine;

namespace Managers
{
    public class GameManager : Singleton<GameManager>
    {
        // Esempio di variabili che potresti voler mantenere
        public int playerScore;
        public string playerName;

        public SceneManager sceneManager;

        void Start()
        {
            sceneManager = SceneManager.Instance;
        }

        protected override void Awake()
        {
            base.Awake();
            DontDestroyOnLoad(gameObject); // Mantiene il GameManager tra le scene
        }

        // Metodi per gestire le informazioni del gioco
        public void SetPlayerScore(int score)
        {
            playerScore = score;
        }

        public int GetPlayerScore()
        {
            return playerScore;
        }
    }
}
