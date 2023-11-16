
using UnityEngine;


namespace RoguelikeGeneratorPro
{
    [ExecuteInEditMode]
    public class RotationRandomizer : MonoBehaviour
    {
        public enum rotationDirection {X, Y, Z};

        [Header("Rotation direction")]
        public rotationDirection rotation = rotationDirection.Y;


        /**/


        private void Start()
        {
            if (UnityEditor.SceneManagement.PrefabStageUtility.GetCurrentPrefabStage() == null)
            {
                if (rotation == rotationDirection.X) this.transform.localRotation = transform.localRotation * Quaternion.Euler(Random.Range(0, 360), 0f, 0f);
                else if (rotation == rotationDirection.Y) this.transform.localRotation = transform.localRotation * Quaternion.Euler(0f, Random.Range(0, 360), 0f);
                else this.transform.localRotation = transform.localRotation * Quaternion.Euler(0f, 0f, Random.Range(0, 360));
            }
        }
    }
}