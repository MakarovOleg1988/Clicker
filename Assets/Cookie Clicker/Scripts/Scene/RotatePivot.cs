using System.Collections;
using UnityEngine;

namespace ClickerTestTask
{
    public class RotatePivot : MonoBehaviour
    {
        public bool isMoon, isSun;

        public bool isActive = false;

        [SerializeField]
        private float speedRotation;

        [SerializeField]
        private float delayAtStartTimer, RepeatDelayTimer ,currentTimer;

        private void Start()
        {
            currentTimer = delayAtStartTimer;
        }

        private void Update()
        {
            if (isSun == false && isMoon == false) return;

            RotateMoonAndSun();
            Timer();
        }
        private void RotateMoonAndSun()
        {
            if (isActive == true) transform.Rotate(-Vector3.forward * speedRotation * Time.deltaTime);
        }

        public bool Timer()
        {
            if (currentTimer >= RepeatDelayTimer / 2 && currentTimer <= RepeatDelayTimer)
            {
                currentTimer -= Time.deltaTime;
                return isActive = true;
            }
            else if (currentTimer <= RepeatDelayTimer / 2 && currentTimer > 0)
            {
                currentTimer -= Time.deltaTime;
                return isActive = false;
            }
            else if (currentTimer <= 0)
            {
                currentTimer = RepeatDelayTimer;
                return isActive = true;
            }
            else return isActive = false;
        }
    }
}
