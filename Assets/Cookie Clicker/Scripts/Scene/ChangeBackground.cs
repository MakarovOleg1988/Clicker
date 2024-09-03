using UnityEngine;

namespace ClickerTestTask
{
    public class ChangeBackground: MonoBehaviour
    {
        private GameObject moonPivot;

        [SerializeField]
        private Sprite[] backgroundSprite;

        private SpriteRenderer background;

        [SerializeField]
        private ParticleSystem particleSystemStars;

        private void Start()
        {
            moonPivot = GameObject.FindGameObjectWithTag("MoonPivot");
            background = GetComponent<SpriteRenderer>();
        }
        private void Update()
        {
            ChangeColorBackground();
        }

        private void ChangeColorBackground()
        {
            if (moonPivot.GetComponent<RotatePivot>().isActive == false)
            {
                background.sprite = backgroundSprite[0];
                particleSystemStars.Stop(withChildren: true);
            }
            else if (moonPivot.GetComponent<RotatePivot>().isActive == true)
            {
                background.sprite = backgroundSprite[1];
                particleSystemStars.Play(withChildren: true);
            }
        }
    }
}