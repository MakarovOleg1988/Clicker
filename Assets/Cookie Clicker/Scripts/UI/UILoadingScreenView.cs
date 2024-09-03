using UnityEngine;

namespace CookieClicker
{
    public class UILoadingScreenView: MonoBehaviour
    {
        [SerializeField]
        private GameObject loadingScreen;

        private UIParent uiParent;

        private Camera camera;

        private void Start()
        {
            uiParent = FindFirstObjectByType<UIParent>();
            camera = Camera.main;

            SetParent(); 
        }

        private void SetParent()
        {
            this.gameObject.transform.parent = uiParent.transform.parent;
            loadingScreen.GetComponent<Canvas>().worldCamera = camera;
        }

        public void ShowLoadingScreen()
        {
            loadingScreen.Activation();
        }

        public void HideLoadingScreen()
        {
            loadingScreen.Deactivation();
        }
    }
}
