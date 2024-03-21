using UnityEngine;

namespace VRGlobalNegotiationQuest
{
    public sealed class SetGizmos : MonoBehaviour
    {
        [SerializeField]
        private bool isCube;

        [SerializeField]
        private bool isSphere;

        private Vector3 scaleGizmos;

        private void OnValidate()
        {
            scaleGizmos = transform.localScale;
        }

        public void OnDrawGizmosSelected()
        {
            if (isCube == true)
            {
                Gizmos.color = new Color(1.0f, 200.0f, 0f, 100.0f);
                Gizmos.DrawCube(transform.position, scaleGizmos);
            }

            if (isSphere == true)
            {
                Gizmos.color = new Color(1.0f, 200.0f, 0f, 100.0f);
                Gizmos.DrawSphere(transform.position, 0.2f);
            }
        }
    }
}
