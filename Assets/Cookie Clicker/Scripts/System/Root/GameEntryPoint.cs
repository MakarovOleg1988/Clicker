using UnityEngine;
using VRGlobalNegotiationQuest;

namespace CookieClicker
{
    public class GameEntryPoint
    {
        private static GameEntryPoint instance;

        private Coroutines coroutines;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void AutoStartGame()
        {
            Application.targetFrameRate = 45;
            Screen.sleepTimeout = SleepTimeout.NeverSleep;

            instance = new GameEntryPoint();
            instance.RunGame();
        }

        private GameEntryPoint()
        {
            coroutines = new GameObject("[Coroutines]").AddComponent<Coroutines>();

            GameObject UIprefab = Resources.Load<GameObject>(SaveStringPath.loadingCanvasPrefabPath);
            GameObject.Instantiate(UIprefab);

            Object.DontDestroyOnLoad(coroutines.gameObject);
            Object.DontDestroyOnLoad(UIprefab);
        }

        private void RunGame()
        { 
        
        }
    }
}