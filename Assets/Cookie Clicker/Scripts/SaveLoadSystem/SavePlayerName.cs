using System.IO;
using UnityEngine;
using UnityEngine.UI;

namespace ClickerTestTask
{
    public partial class SavePlayerName : MonoBehaviour
    {
        [SerializeField]
        private InputField nameField;

        public void SaveName()
        {
            PlayersData data = new PlayersData();
            data.playersName = nameField.text;

            string json = JsonUtility.ToJson(data);

            File.WriteAllText(Application.persistentDataPath + "/SaveFile.json", json);
        }
    }
}
