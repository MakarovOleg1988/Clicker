using System.Collections;
using UnityEngine;

namespace ClickerTestTask
{
    public class LevelController: MonoBehaviour
    {
        [SerializeField]
        private float _timePerLevel;

        private CommonButtonController _commonButtonController;

        private void Start()
        {
            _commonButtonController = FindObjectOfType<CommonButtonController>();
            StartCoroutine(EndOfLevelCoroutine());
        }

        private IEnumerator EndOfLevelCoroutine()
        {
            yield return new WaitForSeconds(_timePerLevel);
            _commonButtonController.StopGame();
        }
    }
}