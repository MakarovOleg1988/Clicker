using System;

namespace ClickerTestTask
{
    public interface IEventManager
    {
        public static event Action _onSetClickButton;
        public static event Action _onSetEatCookiesButton;

        public static void SetClickButton()
        {
            _onSetClickButton?.Invoke();
        }

        public static void SetEatCookiesButton()
        {
            _onSetEatCookiesButton?.Invoke();
        }
    }
}