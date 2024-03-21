using System;
using UnityEngine;

namespace ClickerTestTask
{
    public class SoundController : MonoBehaviour, IEventManager
    {
        public AudioSource _mainMusic;
        public AudioSource _clickSound;
        public AudioSource _cookiesSound;

        [Space, SerializeField]
        private GameObject _muteMusic;
        [SerializeField]
        private GameObject _muteSound;

        private bool _musicOff = false;
        private bool _soundOff = false;

        private void Start()
        {
            IEventManager._onSetClickButton += SetClickButton;
            IEventManager._onSetEatCookiesButton += SetEatCookiesButton;
        }

        private void SetClickButton()
        {
            _clickSound.Play();
        }

        private void SetEatCookiesButton()
        {
            _cookiesSound.Play();
        }

        public void VolumeMusic()
        {
            if (_musicOff == false)
            {
                _musicOff = true;
                _mainMusic.volume = 0;
                _muteMusic.SetActive(true);
            }
            else if (_musicOff == true)
            {
                _musicOff = false;
                _mainMusic.volume = 0.2f;
                _muteMusic.SetActive(false);
            }
        }

        public void VolumeSound()
        {
            if (_soundOff == false)
            {
                _soundOff = true;
                _clickSound.volume = 0;
                _muteSound.SetActive(true);
            }
            else if (_soundOff == true)
            {
                _soundOff = false;
                _clickSound.volume = 1f;
                _muteSound.SetActive(false);
            }
        }

        private void OnDestroy()
        {
            IEventManager._onSetClickButton -= SetClickButton;
            IEventManager._onSetEatCookiesButton -= SetEatCookiesButton;
        }
    }
}
