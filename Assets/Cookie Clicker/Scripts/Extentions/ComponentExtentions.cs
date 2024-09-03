using UnityEngine;

namespace CookieClicker
{
    public static class ComponentExtentions
    {
        public static void Activation(this GameObject gameObject) => gameObject.SetActive(true);
        public static void Deactivation(this GameObject gameObject) => gameObject.SetActive(false);

        public static void ActivationComponent(MonoBehaviour component) => component.enabled = true;
        public static void DeactivationComponent(MonoBehaviour component) => component.enabled = false;
    }
}
