using UnityEngine;

namespace Managers
{
    [System.Serializable]
    public class SceneNames : MonoBehaviour
    {
        [SerializeField]
        private Object teamLogScreen;

        [SerializeField]
        private Object splashScreen;

        [SerializeField]
        private Object mainMenuScene;

        // Proprietà pubbliche per accedere ai riferimenti
        public Object TeamLogScreen => teamLogScreen;
        public Object SplashScreen => splashScreen;
        public Object MainMenuScene => mainMenuScene;
    }
}
