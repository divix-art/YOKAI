using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class SceneManager : Singleton<SceneManager>
    {
        [SerializeField]
        private SceneNames sceneNames;

        protected override void Awake()
        {
            base.Awake();
            DontDestroyOnLoad(gameObject);
        }

        // Metodo per caricare una scena utilizzando il nome serializzato
        public void LoadScene(Object sceneObject)
        {
            if (sceneObject != null)
            {
                string sceneName = sceneObject.name;
                Debug.Log("Carico la scena :>> " + sceneName);
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
            }
            else
            {
                Debug.LogError("Scene object is null!");
            }
        }

        // Proprietà per accedere a SceneNames
        public SceneNames SceneNames => sceneNames;

        // Esempio di metodo per caricare la scena predefinita
        public void LoadDefaultScene()
        {
            LoadScene(sceneNames.TeamLogScreen);
        }
    }
}