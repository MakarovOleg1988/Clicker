using System.Collections;
using TMPro;
using UnityEngine;

namespace ClickerTestTask
{
    public class IssuingGifts : MonoBehaviour
    {
        private Bootstrap _bootstrap;

        [SerializeField]
        private GameObject _gift;

        [SerializeField]
        private TextMeshProUGUI _textTimer;

        [SerializeField]
        private ParticleSystem _giftParticle;

        private float _giftTimeSeconds = 00f;
        private float _giftTimeMinutes = 60f;
        private bool _giftEnabled = false;

        private void Awake()
        {
            _giftParticle.Stop();
            _textTimer.text = $"{_giftTimeMinutes} : {_giftTimeSeconds}";
        }

        private void Update()
        {
            if (_giftEnabled)
            {
                _giftTimeSeconds -= Time.deltaTime;
                _textTimer.text = $"{Mathf.Round(_giftTimeMinutes)} : {Mathf.Round(_giftTimeSeconds)}";
            }
        }

        private void Start()
        {
            _bootstrap = FindObjectOfType<Bootstrap>();
        }

        public void DailyIssuing()
        {
            _giftEnabled = true;
            _bootstrap.ticketValue += 20;
            _bootstrap.ticketValueText.text = _bootstrap.ticketValue.ToString();
            _gift.SetActive(false);
            StartCoroutine(GiftParticleOneShot());
        }

        private IEnumerator GiftParticleOneShot()
        {
            _giftParticle.Play();
            yield return new WaitForSeconds(2f);
            _giftParticle.Stop();
        }
    }
}