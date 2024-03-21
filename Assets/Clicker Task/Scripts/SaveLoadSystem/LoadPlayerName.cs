using System.IO;
using TMPro;
using UnityEngine;

namespace ClickerTestTask
{
    public class LoadPlayerName : MonoBehaviour
    {
        public string PlayerName;

        public void LoadName()
        {
            string path = Application.persistentDataPath + "/SaveFile.json";

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                PlayersData data = JsonUtility.FromJson<PlayersData>(json);

                PlayerName = data.playersName;
            }
        }
    }
}