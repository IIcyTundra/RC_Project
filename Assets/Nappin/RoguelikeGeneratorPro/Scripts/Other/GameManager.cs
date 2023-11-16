using static RoguelikeGeneratorPro.RoguelikeGeneratorPro;
using UnityEngine;


namespace RoguelikeGeneratorPro
{
    public class GameManager : MonoBehaviour
    {
        [Header("Generate player")]
        public bool placePlayer = false;
        public float playerHeightOffset = 0f;
        public GameObject playerObj;

        [Header("Generate target")]
        public bool placeTarget = false;
        public float targetHeightOffset = 0f;
        public GameObject targetObj;

        [Header("Generator references")]
        public RoguelikeGeneratorPro[] levelGenerators;


        private RoguelikeGeneratorPro mainLevelGenerator;
        private tileType[,] tiles;
        private Vector2Int levelSize;
        private float tilesSize;
        private levelRotation levelRot;
        private genType generation;


        /**/


        private void Start()
        {
            if (levelGenerators.Length > 0)
            {
                //generate level
                mainLevelGenerator = levelGenerators[0];
                for (int i = 0; i < levelGenerators.Length; i++) levelGenerators[i].RigenenerateLevel();

                //get generation info
                if (placePlayer || placeTarget)
                {
                    tiles = mainLevelGenerator.GetTiles();
                    levelSize = mainLevelGenerator.GetLevelSize();
                    tilesSize = mainLevelGenerator.GetTilesSize();
                    levelRot = mainLevelGenerator.GetLevelRotation();
                    generation = mainLevelGenerator.GetGenerationType();
                }

                //place objs
                if (placePlayer) PlacePlayer();
                if (placeTarget) PlaceTarget();
            }
        }


        private void PlacePlayer()
        {
            for (int x = 0; x < levelSize.x - 1; x++)
            {
                for (int y = 0; y < levelSize.y - 1; y++)
                {
                    if (tiles[x, y] == tileType.floor)
                    {
                        if(generation == genType.generateTile) GameObject.Instantiate(playerObj, new Vector3(x + tilesSize / 2, y + tilesSize / 2, playerHeightOffset) + mainLevelGenerator.transform.localPosition, Quaternion.identity);
                        else if (levelRot == levelRotation.XZ) GameObject.Instantiate(playerObj, new Vector3(x * tilesSize, playerHeightOffset, y * tilesSize) + mainLevelGenerator.transform.localPosition, Quaternion.identity);
                        else if (levelRot == levelRotation.XY) GameObject.Instantiate(playerObj, new Vector3(x * tilesSize, y * tilesSize, playerHeightOffset) + mainLevelGenerator.transform.localPosition, Quaternion.identity);
                        else GameObject.Instantiate(playerObj, new Vector3(playerHeightOffset, y * tilesSize, x * tilesSize) + mainLevelGenerator.transform.localPosition, Quaternion.identity);

                        goto EndLoop;
                    }
                }
            }

            EndLoop: Debug.Log("Player positioning loop ended");
        }


        private void PlaceTarget()
        {
            for (int x = levelSize.x - 1; x > 0; x--)
            {
                for (int y = levelSize.y - 1; y > 0; y--)
                {
                    if (tiles[x, y] == tileType.floor)
                    {
                        if (generation == genType.generateTile) GameObject.Instantiate(targetObj, new Vector3(x + tilesSize / 2, y + tilesSize / 2, targetHeightOffset) + mainLevelGenerator.transform.localPosition, Quaternion.identity);
                        else if (levelRot == levelRotation.XZ) GameObject.Instantiate(targetObj, new Vector3(x * tilesSize, targetHeightOffset, y * tilesSize) + mainLevelGenerator.transform.localPosition, Quaternion.identity);
                        else if (levelRot == levelRotation.XY) GameObject.Instantiate(targetObj, new Vector3(x * tilesSize, y * tilesSize, targetHeightOffset) + mainLevelGenerator.transform.localPosition, Quaternion.identity);
                        else GameObject.Instantiate(targetObj, new Vector3(targetHeightOffset, y * tilesSize, x * tilesSize) + mainLevelGenerator.transform.localPosition, Quaternion.identity);

                        goto EndLoop;
                    }
                }
            }

            EndLoop: Debug.Log("Target positioning loop ended");
        }
    }
}