using CookieClicker;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace ClickerTestTask
{
    public class LoadingBar : MonoBehaviour
    {
        [SerializeField, Tooltip("Слидер")]
        private Slider progressBar;

        [SerializeField,Header("Канвас с загрузкой")]
        private GameObject loadingCanvas;

        [SerializeField, Header("Скорость симуляции загрузки")]
        private float speedTimer = 0.001f;

        private void Start()
        {
            progressBar.value = 0.0f;

            StartCoroutine(StartLoadingBarCoroutine(speedTimer));
        }

        private IEnumerator StartLoadingBarCoroutine(float delayTimer)
        {
            while (progressBar.value < 0.98f)
            {
                yield return new WaitForSeconds(delayTimer);
                progressBar.value += delayTimer;
            }

            loadingCanvas.Deactivation();

            yield return null;
        }
    }
}
