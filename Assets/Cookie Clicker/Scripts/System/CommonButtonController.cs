using UnityEngine;

namespace ClickerTestTask
{
    public class CommonButtonController : MonoBehaviour, IEventManager
    {
        public GameObject playButton;
        public GameObject quitButton;
        public GameObject chooseLevelPanel;
        public GameObject settingPanel;
        public GameObject storePanel;
        public GameObject giftPanel;
        public GameObject stopGameButton;
        public GameObject quitGamePanel;

        public GameObject spawnObj;

        public void TurnOnSettingPanel()
        {
            IEventManager.SetClickButton();
            playButton.SetActive(false);
            quitButton.SetActive(false);
            settingPanel.SetActive(true);
        }

        public void TurnOnStorePanel()
        {
            IEventManager.SetClickButton();
            playButton.SetActive(false);
            quitButton.SetActive(false);
            storePanel.SetActive(true);
        }

        public void TurnOnChooseLevelPanel()
        {
            IEventManager.SetClickButton();
            playButton.SetActive(false);
            quitButton.SetActive(false);
            chooseLevelPanel.SetActive(true);
        }

        public void TurnOnGiftPanel()
        {
            IEventManager.SetClickButton();
            playButton.SetActive(false);
            quitButton.SetActive(false);
            giftPanel.SetActive(true);
        }

        public void BackToLobby()
        {
            IEventManager.SetClickButton();
            playButton.SetActive(true);
            quitButton.SetActive(true);
            quitGamePanel.SetActive(false);
            chooseLevelPanel.SetActive(false);
            storePanel.SetActive(false);
            giftPanel.SetActive(false);
            settingPanel.SetActive(false);
        }

        public void StartGame()
        {
            IEventManager.SetClickButton();
            stopGameButton.SetActive(true);
            chooseLevelPanel.SetActive(false);
            spawnObj.GetComponent<SpawnCookies>().StartSpawnCookiesPrefab();
        }

        public void StopGame()
        {
            IEventManager.SetClickButton();
            stopGameButton.SetActive(false);
            spawnObj.GetComponent<SpawnCookies>().CancelSpawnCookiesPrefab();
        }

        public void TurOnQuitGamePanel()
        {
            IEventManager.SetClickButton();
            quitGamePanel.SetActive(true);
        }

        public void QuitGame()
        {
            IEventManager.SetClickButton();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE_WIN && !UNITY_EDITOR
            Application.Quit();
#endif
        }
    }
}
