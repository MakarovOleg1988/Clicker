using System.Collections;
using TMPro;
using UnityEngine;

namespace VRGlobalNegotiationQuest
{
    public sealed class DisplayFPS : MonoBehaviour
    {
        [SerializeField]
        private float goodFpsThreshold = 55;
        [SerializeField]
        private float badFpsThreshold = 25;

        float updateInterval = 0.5f;

        private TextMeshProUGUI textOutput = null;

        private float deltaTime = 0.0f;
        private int framesPerSecond = 0;

        private void Awake()
        {
            textOutput = GetComponentInChildren<TextMeshProUGUI>();
        }

        private void Start()
        {
            StartCoroutine(ShowFPS());
        }

        private void Update()
        {
            CalculateCurrentFPS();
        }

        private void CalculateCurrentFPS()
        {
            deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
            framesPerSecond = (int)(1.0f / deltaTime);
        }

        private IEnumerator ShowFPS()
        {
            while (true)
            {
                if (framesPerSecond >= goodFpsThreshold)
                {
                    textOutput.color = Color.green;
                }
                else if (framesPerSecond >= badFpsThreshold)
                {
                    textOutput.color = Color.yellow;
                }
                else
                {
                    textOutput.color = Color.red;
                }

                textOutput.text = "FPS: " + framesPerSecond;
                yield return new WaitForSeconds(updateInterval);
            }
        }
    }
}