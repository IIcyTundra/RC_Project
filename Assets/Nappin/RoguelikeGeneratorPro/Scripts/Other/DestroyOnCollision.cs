using UnityEngine;


namespace RoguelikeGeneratorPro
{
    public class DestroyOnCollision : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}