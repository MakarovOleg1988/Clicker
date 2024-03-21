using UnityEngine;

namespace ClickerTestTask
{
    [CreateAssetMenu(fileName = "Price.asset", menuName ="Resources/Create Price")]
    public class PricePurposeScriptableObject: ScriptableObject
    {
        public int[] _pricePurposeValue;
    }
}