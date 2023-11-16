
using UnityEngine;


namespace RoguelikeGeneratorPro
{
    [ExecuteInEditMode]
    public class SpawnRandomizer : MonoBehaviour
    {
        [Header("Items reference")]
        public GameObject[] primaryItems;
        public GameObject[] secondaryItems;
        
        [Header("Spawn specifics")]
        [Range(0, 100)]
        public int secondaryItemChance = 15;
        public Vector3 spawnOffset = Vector3.zero;
        public bool removeWhenEmpty = true;


        /**/


        private void Start()
        {
            if (UnityEditor.SceneManagement.PrefabStageUtility.GetCurrentPrefabStage() == null)
            {
                if (Random.Range(0, 100) < secondaryItemChance) SpawnItems(secondaryItems);
                else if (primaryItems.Length > 0) SpawnItems(primaryItems);
                else if (removeWhenEmpty)
                {
                    if (Application.isPlaying) GameObject.Destroy(this.gameObject);
                    else GameObject.DestroyImmediate(this.gameObject);
                }
            }
        }


        private void SpawnItems(GameObject[] _items)
        {
            int randomValue = Random.Range(0, _items.Length);
            GameObject instObj = GameObject.Instantiate(_items[randomValue], this.transform.position + spawnOffset, Quaternion.identity);

            instObj.transform.parent = this.transform;
            instObj.transform.localRotation = Quaternion.Euler(Vector3.zero);
        }
    }
}