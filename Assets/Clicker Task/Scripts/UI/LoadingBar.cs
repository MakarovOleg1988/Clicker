using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace ClickerTestTask
{
    public class LoadingBar : MonoBehaviour
    {
        [SerializeField]
        private Slider progressBar;

        [SerializeField]
        private GameObject loadingCanvas;

        private void Start()
        {
            progressBar.value = 0.0f;

            StartCoroutine(LoadingStartScene(0.001f));
        }

        private IEnumerator LoadingStartScene(float delayTimer)
        {
            while (progressBar.value < 0.98f)
            {
                yield return new WaitForSeconds(delayTimer);
                progressBar.value += delayTimer;
            }

            loadingCanvas.SetActive(false);

            yield return null;
        }
    }
}
