using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ClickerTestTask
{
    public class ClickSystem : MonoBehaviour, IEventManager, IPointerClickHandler
    {
        private TextMeshProUGUI _ticketValueText;

        private void Start()
        {
            _ticketValueText = GameObject.Find("Ticket Value Text").GetComponent<TextMeshProUGUI>();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (Bootstrap.Instance.powerupX2Ticket == true) Bootstrap.Instance.ticketValue += 2;
            else if(Bootstrap.Instance.powerupX2Ticket == false) Bootstrap.Instance.ticketValue += 1;
            _ticketValueText.text = Bootstrap.Instance.ticketValue.ToString();

            IEventManager.SetEatCookiesButton();
            gameObject.GetComponentInChildren<ParticleSystem>().Play(withChildren: true);

            StartCoroutine(DestroyCookie());
        }

        private IEnumerator DestroyCookie()
        {
            yield return new WaitForSeconds(0.4f);
            Destroy(this.gameObject);
        }
    }
}