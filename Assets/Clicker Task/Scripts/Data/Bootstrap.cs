using TMPro;
using UnityEngine;

namespace ClickerTestTask
{
    public class Bootstrap: MonoBehaviour
    {
        private LoadPlayerName loadPlayerName;

        public int ticketValue = 40;

        public int levelValue = 1;

        public bool powerupX2Ticket = false;

        public TextMeshProUGUI ticketValueText;
        public TextMeshProUGUI playerNameText;

        public GameObject powerupX2TicketIcon;

        public static Bootstrap Instance { get; set; }

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(this.gameObject);
        }

        private void Start()
        {
            loadPlayerName = FindObjectOfType<LoadPlayerName>();
            loadPlayerName.LoadName();

            ticketValueText.text = ticketValue.ToString();

            playerNameText.text = loadPlayerName.PlayerName;
        }
    }
}