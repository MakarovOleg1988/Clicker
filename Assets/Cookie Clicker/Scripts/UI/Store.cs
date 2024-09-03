using TMPro;
using UnityEngine;

namespace ClickerTestTask
{
    public class Store : MonoBehaviour
    {
        [SerializeField]
        public TextMeshProUGUI[] pricePurposeText;

        [SerializeField]
        private GameObject[] lockPurpose;

        [SerializeField]
        private PricePurposeScriptableObject pricePurposeScriptableObject;

        private void Start()
        {
            SetPrice();
        }

        public void SetPrice()
        {
            for (int i = 0; i < pricePurposeText.Length; i++)
            {
                pricePurposeText[i].text = $"Required {pricePurposeScriptableObject._pricePurposeValue[i]}";
            }
        }

        private void Update()
        {
            if (Bootstrap.Instance.ticketValue >= pricePurposeScriptableObject._pricePurposeValue[0]) lockPurpose[0].SetActive(false);
            if (Bootstrap.Instance.ticketValue >= pricePurposeScriptableObject._pricePurposeValue[1]) lockPurpose[1].SetActive(false);
            if (Bootstrap.Instance.ticketValue >= pricePurposeScriptableObject._pricePurposeValue[2]) lockPurpose[2].SetActive(false);
            if (Bootstrap.Instance.ticketValue >= pricePurposeScriptableObject._pricePurposeValue[3]) lockPurpose[3].SetActive(false);
            if (Bootstrap.Instance.ticketValue >= pricePurposeScriptableObject._pricePurposeValue[4]) lockPurpose[4].SetActive(false);
            if (Bootstrap.Instance.ticketValue >= pricePurposeScriptableObject._pricePurposeValue[5]) lockPurpose[5].SetActive(false);
        }

        public void ActivePowerup()
        {
            if (Bootstrap.Instance.ticketValue > pricePurposeScriptableObject._pricePurposeValue[0])
            {
                Bootstrap.Instance.powerupX2Ticket = true;
                Bootstrap.Instance.ticketValue -= pricePurposeScriptableObject._pricePurposeValue[0];
                Bootstrap.Instance.ticketValueText.text = Bootstrap.Instance.ticketValue.ToString();
                Bootstrap.Instance.powerupX2TicketIcon.SetActive(true);
            }
        }
    }
}