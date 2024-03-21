using UnityEngine;

namespace ClickerTestTask
{
    public class SpawnCookies : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] cookiePrefab;

        [SerializeField]
        private float boardX = 10.0f, startTime, minDelayTime, maxDelayTime;

        public void StartSpawnCookiesPrefab()
        {
            InvokeRepeating("SpawnCookiesPrefab", startTime, Random.Range(minDelayTime, maxDelayTime));
        }

        private void SpawnCookiesPrefab()
        {
            int indexCookie = Random.Range(0, cookiePrefab.Length);

            float PosX = Random.Range(-boardX, boardX);
            Vector2 SpawnPos = new Vector2(PosX, transform.position.y);

            Instantiate(cookiePrefab[indexCookie], SpawnPos, cookiePrefab[indexCookie].transform.rotation);
        }

        public void CancelSpawnCookiesPrefab()
        {
            CancelInvoke("SpawnCookiesPrefab");
        }
    }
}
