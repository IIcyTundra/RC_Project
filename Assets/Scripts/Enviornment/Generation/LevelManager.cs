using System.Collections;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets.Scripts.Enviornment.Generation
{
    public class LevelManager : MonoBehaviour
    {
        Tilemap tilemap;
        [SerializeField] private  LevelGenerator levelGenerator;
        public Tile Floor;
        public Tile Wall;
        private void Awake()
        {
            tilemap = GetComponent<Tilemap>();
            levelGenerator = new LevelGenerator(Floor, Wall, tilemap, 500);
        }
        // Use this for initialization
        void Start()
        {
            levelGenerator.generate();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}