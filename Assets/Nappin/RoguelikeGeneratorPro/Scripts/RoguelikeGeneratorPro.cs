using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


namespace RoguelikeGeneratorPro
{
    public class RoguelikeGeneratorPro : MonoBehaviour
    {
        #region Variables

        //Types
        public enum tileType { empty, floor, wall, detail };
        public enum overlayType { empty, wallPattern, wallRandom, floorPattern, floorRandom };
        public enum patternType { perlinNoise, checker, wideChecker, lineLeft, lineRight };
        public enum levelRotation { XZ, XY , ZY};
        public enum genType { generateObj, generateTile, noGeneration };
        private struct pathMaker { public Vector2 direction; public Vector2 position; };


        //Level dimensions
        public Vector2Int levelSize = new Vector2Int(80, 80);
        public float tileSize = 1f;
        public float percentLevelToFill = 25.3f;
        public bool spawnCornerWalls = true;
        public bool removeUnnaturalWalls = false;
        public bool useSeed = false;
        public int generationSeed = 99;


        //PathMaker properties
        public int pathMakerDestructionChance = 30;
        public int pathMakerSpawnChance = 39;
        public int pathMakerRotationChance = 44;
        public float pathMakerRotatesLeft = 8.080808f;
        public float pathMakerRotatesRight = 38.38384f;
        public float pathMakerRotatesBackwords = 53.53535f;
        public int pathMakerMaxDensity = 2;


        //Chunk properties
        public int chunkSpawnChance = 4;
        public float chunkChance2x2 = 95;
        public float chunkChance3x3 = 5;


        //Pattern floor overlay
        public patternType patternFloor = patternType.checker;
        public Vector2 noiseScaleFloor = new Vector2(0.1f, 0.1f);
        public float noiseCutoffFloor = 0.5f;


        //Pattern wall overlay
        public patternType patternWall = patternType.checker;
        public Vector2 noiseScaleWall = new Vector2(0.1f, 0.1f);
        public float noiseCutoffWall = 0.5f;


        //Random floor overlay
        public int randomFloorOverlayChance = 1;


        //Random wall overlay
        public int randomWallOverlayChance = 1;


        //Tiles generation references
        public int tabSelected = 0;
        public genType generation = 0;
        public bool fillAllTiles = false;
        public bool drawCorners = false;

        public bool drawEmptyTiles = true;
        public GameObject emptyTileObj;

        public bool drawFloorOverlayPatternTiles = true;
        public GameObject patternFloorTileObj;

        public bool drawFloorOverlayRandomTiles = true;
        public GameObject randomFloorTileObj;

        public bool drawTilesOrientation = true;
        public GameObject floorTileObj_1;
        public GameObject floorTileObj_2;
        public GameObject floorTileObj_3;
        public GameObject floorTileObj_4;
        public GameObject floorTileObj_5;
        public GameObject floorTileObj_6;
        public GameObject floorTileObj_7;
        public GameObject floorTileObj_8;
        public GameObject floorTileObj_9;
        public GameObject floorTileObj_10;
        public GameObject floorTileObj_11;
        public GameObject floorTileObj_12;
        public GameObject floorTileObj_13;
        public GameObject floorTileObj_14;
        public GameObject floorTileObj_15;
        
        public GameObject floorTileObj_C1;
        public GameObject floorTileObj_C2;
        public GameObject floorTileObj_C3;
        public GameObject floorTileObj_C4;
        public GameObject floorTileObj_C5;
        public GameObject floorTileObj_C6;
        public GameObject floorTileObj_C7;
        public GameObject floorTileObj_C8;
        public GameObject floorTileObj_C9;
        public GameObject floorTileObj_C10;
        public GameObject floorTileObj_C11;
        public GameObject floorTileObj_C12;
        public GameObject floorTileObj_C13;
        public GameObject floorTileObj_C14;
        public GameObject floorTileObj_C15;
        public GameObject floorTileObj_C16;
        public GameObject floorTileObj_C17;
        public GameObject floorTileObj_C18;
        public GameObject floorTileObj_C19;
        public GameObject floorTileObj_C20;
        public GameObject floorTileObj_C21;
        public GameObject floorTileObj_C22;
        public GameObject floorTileObj_C23;
        public GameObject floorTileObj_C24;
        public GameObject floorTileObj_C25;
        public GameObject floorTileObj_C26;
        public GameObject floorTileObj_C27;
        public GameObject floorTileObj_C28;
        public GameObject floorTileObj_C29;
        public GameObject floorTileObj_C30;
        public GameObject floorTileObj_C31;

        public GameObject wallTileObj_1;
        public GameObject wallTileObj_2;
        public GameObject wallTileObj_3;
        public GameObject wallTileObj_4;
        public GameObject wallTileObj_5;
        public GameObject wallTileObj_6;
        public GameObject wallTileObj_7;
        public GameObject wallTileObj_8;
        public GameObject wallTileObj_9;
        public GameObject wallTileObj_10;
        public GameObject wallTileObj_11;
        public GameObject wallTileObj_12;
        public GameObject wallTileObj_13;
        public GameObject wallTileObj_14;
        public GameObject wallTileObj_15;

        public GameObject wallTileObj_C1;
        public GameObject wallTileObj_C2;
        public GameObject wallTileObj_C3;
        public GameObject wallTileObj_C4;
        public GameObject wallTileObj_C5;
        public GameObject wallTileObj_C6;
        public GameObject wallTileObj_C7;
        public GameObject wallTileObj_C8;
        public GameObject wallTileObj_C9;
        public GameObject wallTileObj_C10;
        public GameObject wallTileObj_C11;
        public GameObject wallTileObj_C12;
        public GameObject wallTileObj_C13;
        public GameObject wallTileObj_C14;
        public GameObject wallTileObj_C15;
        public GameObject wallTileObj_C16;
        public GameObject wallTileObj_C17;
        public GameObject wallTileObj_C18;
        public GameObject wallTileObj_C19;
        public GameObject wallTileObj_C20;
        public GameObject wallTileObj_C21;
        public GameObject wallTileObj_C22;
        public GameObject wallTileObj_C23;
        public GameObject wallTileObj_C24;
        public GameObject wallTileObj_C25;
        public GameObject wallTileObj_C26;
        public GameObject wallTileObj_C27;
        public GameObject wallTileObj_C28;
        public GameObject wallTileObj_C29;
        public GameObject wallTileObj_C30;
        public GameObject wallTileObj_C31;

        public bool drawWallOverlayPatternTiles = true;
        public GameObject patternWallTileObj_1;
        public GameObject patternWallTileObj_2;
        public GameObject patternWallTileObj_3;
        public GameObject patternWallTileObj_4;
        public GameObject patternWallTileObj_5;
        public GameObject patternWallTileObj_6;
        public GameObject patternWallTileObj_7;
        public GameObject patternWallTileObj_8;
        public GameObject patternWallTileObj_9;
        public GameObject patternWallTileObj_10;
        public GameObject patternWallTileObj_11;
        public GameObject patternWallTileObj_12;
        public GameObject patternWallTileObj_13;
        public GameObject patternWallTileObj_14;
        public GameObject patternWallTileObj_15;

        public bool drawWallOverlayRandomTiles = true;
        public GameObject randomWallTileObj_1;
        public GameObject randomWallTileObj_2;
        public GameObject randomWallTileObj_3;
        public GameObject randomWallTileObj_4;
        public GameObject randomWallTileObj_5;
        public GameObject randomWallTileObj_6;
        public GameObject randomWallTileObj_7;
        public GameObject randomWallTileObj_8;
        public GameObject randomWallTileObj_9;
        public GameObject randomWallTileObj_10;
        public GameObject randomWallTileObj_11;
        public GameObject randomWallTileObj_12;
        public GameObject randomWallTileObj_13;
        public GameObject randomWallTileObj_14;
        public GameObject randomWallTileObj_15;

        public Tile emptyTile;
        public Tile patternFloorTile;
        public Tile randomFloorTile;

        public Tile floorTile_1;
        public Tile floorTile_2;
        public Tile floorTile_3;
        public Tile floorTile_4;
        public Tile floorTile_5;
        public Tile floorTile_6;
        public Tile floorTile_7;
        public Tile floorTile_8;
        public Tile floorTile_9;
        public Tile floorTile_10;
        public Tile floorTile_11;
        public Tile floorTile_12;
        public Tile floorTile_13;
        public Tile floorTile_14;
        public Tile floorTile_15;
        
        public Tile floorTile_C1;
        public Tile floorTile_C2;
        public Tile floorTile_C3;
        public Tile floorTile_C4;
        public Tile floorTile_C5;
        public Tile floorTile_C6;
        public Tile floorTile_C7;
        public Tile floorTile_C8;
        public Tile floorTile_C9;
        public Tile floorTile_C10;
        public Tile floorTile_C11;
        public Tile floorTile_C12;
        public Tile floorTile_C13;
        public Tile floorTile_C14;
        public Tile floorTile_C15;
        public Tile floorTile_C16;
        public Tile floorTile_C17;
        public Tile floorTile_C18;
        public Tile floorTile_C19;
        public Tile floorTile_C20;
        public Tile floorTile_C21;
        public Tile floorTile_C22;
        public Tile floorTile_C23;
        public Tile floorTile_C24;
        public Tile floorTile_C25;
        public Tile floorTile_C26;
        public Tile floorTile_C27;
        public Tile floorTile_C28;
        public Tile floorTile_C29;
        public Tile floorTile_C30;
        public Tile floorTile_C31;

        public Tile wallTile_1;
        public Tile wallTile_2;
        public Tile wallTile_3;
        public Tile wallTile_4;
        public Tile wallTile_5;
        public Tile wallTile_6;
        public Tile wallTile_7;
        public Tile wallTile_8;
        public Tile wallTile_9;
        public Tile wallTile_10;
        public Tile wallTile_11;
        public Tile wallTile_12;
        public Tile wallTile_13;
        public Tile wallTile_14;
        public Tile wallTile_15;

        public Tile wallTile_C1;
        public Tile wallTile_C2;
        public Tile wallTile_C3;
        public Tile wallTile_C4;
        public Tile wallTile_C5;
        public Tile wallTile_C6;
        public Tile wallTile_C7;
        public Tile wallTile_C8;
        public Tile wallTile_C9;
        public Tile wallTile_C10;
        public Tile wallTile_C11;
        public Tile wallTile_C12;
        public Tile wallTile_C13;
        public Tile wallTile_C14;
        public Tile wallTile_C15;
        public Tile wallTile_C16;
        public Tile wallTile_C17;
        public Tile wallTile_C18;
        public Tile wallTile_C19;
        public Tile wallTile_C20;
        public Tile wallTile_C21;
        public Tile wallTile_C22;
        public Tile wallTile_C23;
        public Tile wallTile_C24;
        public Tile wallTile_C25;
        public Tile wallTile_C26;
        public Tile wallTile_C27;
        public Tile wallTile_C28;
        public Tile wallTile_C29;
        public Tile wallTile_C30;
        public Tile wallTile_C31;

        public Tile patternWallTile_1;
        public Tile patternWallTile_2;
        public Tile patternWallTile_3;
        public Tile patternWallTile_4;
        public Tile patternWallTile_5;
        public Tile patternWallTile_6;
        public Tile patternWallTile_7;
        public Tile patternWallTile_8;
        public Tile patternWallTile_9;
        public Tile patternWallTile_10;
        public Tile patternWallTile_11;
        public Tile patternWallTile_12;
        public Tile patternWallTile_13;
        public Tile patternWallTile_14;
        public Tile patternWallTile_15;

        public Tile randomWallTile_1;
        public Tile randomWallTile_2;
        public Tile randomWallTile_3;
        public Tile randomWallTile_4;
        public Tile randomWallTile_5;
        public Tile randomWallTile_6;
        public Tile randomWallTile_7;
        public Tile randomWallTile_8;
        public Tile randomWallTile_9;
        public Tile randomWallTile_10;
        public Tile randomWallTile_11;
        public Tile randomWallTile_12;
        public Tile randomWallTile_13;
        public Tile randomWallTile_14;
        public Tile randomWallTile_15;


        //Level floor collider
        public bool createLevelSizedFloorCollider = false;
        public bool createWall2DCompositeCollider = false;
        public bool deleteFloorBelowOverlay = false;
        public bool createWallGridCollider = true;
        public float levelColliderHeight = 0.1f;
        public levelRotation levelRot;


        //Offset
        public float floorOffset = 0f;
        public float wallOffset = 0f;
        public float overlayOffset = 0.03f;
        public float emptyOffset = 0f;


        //PRIVATE
        private tileType[,] tiles;
        private overlayType[,] overlayTiles;

        private List<pathMaker> pathMakers;
        private Vector2Int levelSizeCut;
        private float iterationsMax = 100000;

        private GameObject gridParent;
        private GameObject floorParent;
        private GameObject wallParent;
        private GameObject emptyParent;
        private GameObject overlayParent;

        #endregion


        /**/


        #region Generation

        public void RigenenerateLevel()
        {
            Clear();
            AssignSeed();
            GenerateLevel();

            Debug.Log("Level generated!");
        }


        public void GenerateLevel()
        {
            Setup();
            
            GenerateFloor();
            GenerateWall();

            if (drawFloorOverlayRandomTiles) InstanciateFloorRandomOverlay();
            if (drawWallOverlayRandomTiles) InstanciateWallRandomOverlay();
            if (drawFloorOverlayPatternTiles) InstanciateFloorOverlay();
            if (drawWallOverlayPatternTiles) InstanciateWallOverlay();

            if(generation != genType.noGeneration) Spawn();

            if (generation == genType.generateObj && createLevelSizedFloorCollider) GenerateFloorCollider();
            else if (generation == genType.generateTile && createWallGridCollider) GenerateWallTileCollider();

            if (generation == genType.generateObj && createWall2DCompositeCollider) GenerateWallCompositeCollider2D();
        }

        #endregion


        #region Setup

        private void Setup()
        {
            //fix variables
            levelSizeCut = new Vector2Int(levelSize.x - 2, levelSize.y - 2);

            if (levelSizeCut.x < 4)
            {
                levelSizeCut.x = 4;
                levelSize.x = 6;
            }
            if (levelSizeCut.y < 4)
            {
                levelSizeCut.y = 4;
                levelSize.y = 6;
            }

            //recaulculate chanches rotation
            float totalChances = pathMakerRotatesLeft + pathMakerRotatesRight + pathMakerRotatesBackwords;
            pathMakerRotatesLeft = pathMakerRotatesLeft * 100f / totalChances;
            pathMakerRotatesRight = pathMakerRotatesRight * 100f / totalChances;
            pathMakerRotatesBackwords = pathMakerRotatesBackwords * 100f / totalChances;

            //recalculate chances 2x2 and 3x3
            float totalBlockChances = chunkChance2x2 + chunkChance3x3;
            chunkChance2x2 = chunkChance2x2 * 100 / totalBlockChances;
            chunkChance3x3 = chunkChance3x3 * 100 / totalBlockChances;

            //reset rotation
            this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);

            //create level parents
            if (generation == genType.generateObj) CreateObjParents();
            else CreateTilesParents();

            //instanciate tiles
            tiles = new tileType[levelSize.x, levelSize.y];
            overlayTiles = new overlayType[levelSize.x, levelSize.y];

            for (int x = 0; x < levelSize.x; x++) for (int y = 0; y < levelSize.y; y++) tiles[x, y] = tileType.empty;
            for (int x = 0; x < levelSize.x; x++) for (int y = 0; y < levelSize.y; y++) overlayTiles[x, y] = overlayType.empty;

            //create first pathMaker
            pathMakers = new List<pathMaker>();
            pathMaker newGenerator = new pathMaker();
            newGenerator.direction = TurnPathMakers(Vector2.up);
            newGenerator.position = new Vector2(Mathf.RoundToInt(levelSizeCut.x / 2.0f), Mathf.RoundToInt(levelSizeCut.y / 2.0f));
            pathMakers.Add(newGenerator);
        }


        private void CreateObjParents()
        {
            floorParent = new GameObject("floorParent");
            floorParent.transform.parent = this.transform;
            floorParent.transform.localPosition = new Vector3(0f, floorOffset, 0f);

            wallParent = new GameObject("wallParent");
            wallParent.transform.parent = this.transform;
            wallParent.transform.localPosition = new Vector3(0f, wallOffset, 0f);

            if (drawEmptyTiles)
            {
                emptyParent = new GameObject("emptyParent");
                emptyParent.transform.parent = this.transform;
                emptyParent.transform.localPosition = new Vector3(0f, emptyOffset, 0f);
            }

            if (drawFloorOverlayPatternTiles || drawFloorOverlayRandomTiles || drawWallOverlayPatternTiles || drawWallOverlayRandomTiles)
            {
                overlayParent = new GameObject("overlayParent");
                overlayParent.transform.parent = this.transform;
                overlayParent.transform.localPosition = new Vector3(0f, overlayOffset, 0f);
            }
        }


        private void CreateTilesParents()
        {
            gridParent = new GameObject("gridParent");
            gridParent.AddComponent<Grid>();
            gridParent.GetComponent<Grid>().cellSwizzle = GridLayout.CellSwizzle.XYZ;
            gridParent.GetComponent<Grid>().cellSize = new Vector3(tileSize, tileSize, tileSize);
            gridParent.transform.parent = this.transform;

            floorParent = new GameObject("floorParent");
            floorParent.AddComponent<Tilemap>();
            floorParent.AddComponent<TilemapRenderer>();
            floorParent.GetComponent<Tilemap>().orientation = Tilemap.Orientation.XY;
            floorParent.transform.parent = gridParent.transform;
            floorParent.transform.position = new Vector3(0f, 0f, floorOffset);

            wallParent = new GameObject("wallParent");
            wallParent.AddComponent<Tilemap>();
            wallParent.AddComponent<TilemapRenderer>();
            wallParent.GetComponent<Tilemap>().orientation = Tilemap.Orientation.XY;
            wallParent.transform.parent = gridParent.transform;
            wallParent.transform.position = new Vector3(0f, 0f, wallOffset);

            if (drawEmptyTiles)
            {
                emptyParent = new GameObject("emptyParent");
                emptyParent.AddComponent<Tilemap>();
                emptyParent.AddComponent<TilemapRenderer>();
                emptyParent.GetComponent<Tilemap>().orientation = Tilemap.Orientation.XY;
                emptyParent.transform.parent = gridParent.transform;
                emptyParent.transform.position = new Vector3(0f, 0f, emptyOffset);
            }

            if (drawFloorOverlayPatternTiles || drawFloorOverlayRandomTiles || drawWallOverlayPatternTiles || drawWallOverlayRandomTiles)
            {
                overlayParent = new GameObject("overlayParent");
                overlayParent.AddComponent<Tilemap>();
                overlayParent.AddComponent<TilemapRenderer>();
                overlayParent.GetComponent<Tilemap>().orientation = Tilemap.Orientation.XY;
                overlayParent.transform.parent = gridParent.transform;
                overlayParent.transform.position = new Vector3(0f, 0f, overlayOffset);
                overlayParent.GetComponent<TilemapRenderer>().sortingOrder = 1;
            }
        }


        private void Clear()
        {
            if (Application.isPlaying)
            {
                int childNum = this.transform.childCount;
                for (var i = childNum - 1; i >= 0; i--) GameObject.Destroy(this.transform.GetChild(i).gameObject);
            }
            else
            {
                int childNum = this.transform.childCount;
                for (var i = childNum - 1; i >= 0; i--) GameObject.DestroyImmediate(this.transform.GetChild(i).gameObject);
            }
        }


        public void AssignSeed()
        {
            if (useSeed) Random.InitState(generationSeed);
        }

        #endregion


        #region Floor

        private void GenerateFloor()
        {
            int iterationsNum = 0;

            while (iterationsNum < iterationsMax)
            {
                //assign floor
                for (int i = 0; i < pathMakers.Count; i++) tiles[(int)pathMakers[i].position.x, (int)pathMakers[i].position.y] = tileType.floor;

                //generate floor
                IteratePathMakers();
                GenerateBlock();
                MovePathMakers();

                //check loop
                if ((float)TileTypeNumber(tileType.floor) * 100f / (float)tiles.Length > percentLevelToFill) break;
                iterationsNum++;
            }
        }

        private void IteratePathMakers()
        {
            for (int i = 0; i < pathMakers.Count; i++)
            {
                //destroy
                if (Random.Range(0, 100) < pathMakerDestructionChance && pathMakers.Count > 1)
                {
                    pathMakers.RemoveAt(i);
                    break;
                }

                //turn
                if (Random.Range(0, 100) < pathMakerRotationChance)
                {
                    pathMaker currentPathMaker = pathMakers[i];
                    currentPathMaker.direction = TurnPathMakers(currentPathMaker.direction);
                    pathMakers[i] = currentPathMaker;
                }

                //spawn
                if (Random.Range(0, 100) < pathMakerSpawnChance && pathMakers.Count < pathMakerMaxDensity)
                {
                    pathMaker currentPathMaker = new pathMaker();
                    currentPathMaker.direction = TurnPathMakers(pathMakers[i].direction);
                    currentPathMaker.position = pathMakers[i].position;
                    pathMakers.Add(currentPathMaker);
                }
            }
        }

        private void GenerateBlock()
        {
            for (int i = 0; i < pathMakers.Count; i++)
            {
                if (Random.Range(0, 100) < chunkSpawnChance)
                {
                    pathMaker currentPathMaker = pathMakers[i];

                    if (Random.Range(0, 100) < chunkChance2x2)
                    {
                        tiles[(int)currentPathMaker.position.x + 1, (int)currentPathMaker.position.y] = tileType.floor;
                        tiles[(int)currentPathMaker.position.x + 1, (int)currentPathMaker.position.y + 1] = tileType.floor;
                        tiles[(int)currentPathMaker.position.x, (int)currentPathMaker.position.y + 1] = tileType.floor;
                    }
                    else
                    {
                        tiles[(int)currentPathMaker.position.x + 1, (int)currentPathMaker.position.y] = tileType.floor;
                        tiles[(int)currentPathMaker.position.x + 2, (int)currentPathMaker.position.y] = tileType.floor;
                        tiles[(int)currentPathMaker.position.x, (int)currentPathMaker.position.y + 1] = tileType.floor;
                        tiles[(int)currentPathMaker.position.x + 1, (int)currentPathMaker.position.y + 1] = tileType.floor;
                        tiles[(int)currentPathMaker.position.x + 2, (int)currentPathMaker.position.y + 1] = tileType.floor;
                        tiles[(int)currentPathMaker.position.x, (int)currentPathMaker.position.y + 2] = tileType.floor;
                        tiles[(int)currentPathMaker.position.x + 1, (int)currentPathMaker.position.y + 2] = tileType.floor;
                        tiles[(int)currentPathMaker.position.x + 2, (int)currentPathMaker.position.y + 2] = tileType.floor;
                    }
                }
            }
        }


        private void MovePathMakers()
        {
            for (int i = 0; i < pathMakers.Count; i++)
            {
                //move
                pathMaker currentPathMaker = pathMakers[i];
                currentPathMaker.position += currentPathMaker.direction;

                //avoid border
                currentPathMaker.position.x = Mathf.Clamp(currentPathMaker.position.x, 1, levelSizeCut.x - 2);
                currentPathMaker.position.y = Mathf.Clamp(currentPathMaker.position.y, 1, levelSizeCut.y - 2);
                pathMakers[i] = currentPathMaker;
            }
        }


        private Vector2 TurnPathMakers(Vector2 _pathMakerDirection)
        {
            int randomValue = Random.Range(0, 100);

            float chanceLeft = pathMakerRotatesLeft;
            float chanceRight = chanceLeft + pathMakerRotatesRight;

            if (randomValue <= chanceLeft)
            {
                if (_pathMakerDirection == Vector2.up) return Vector2.left;
                else if (_pathMakerDirection == Vector2.left) return Vector2.down;
                else if (_pathMakerDirection == Vector2.down) return Vector2.right;
                else return Vector2.up;
            }
            else if (randomValue <= chanceRight)
            {
                if (_pathMakerDirection == Vector2.up) return Vector2.right;
                else if (_pathMakerDirection == Vector2.left) return Vector2.up;
                else if (_pathMakerDirection == Vector2.down) return Vector2.left;
                else return Vector2.down;
            }
            else
            {
                if (_pathMakerDirection == Vector2.up) return Vector2.down;
                else if (_pathMakerDirection == Vector2.left) return Vector2.right;
                else if (_pathMakerDirection == Vector2.down) return Vector2.up;
                else return Vector2.left;
            }
        }

        #endregion


        #region Walls

        private void GenerateWall()
        {
            for (int x = 0; x < levelSize.x - 1; x++)
            {
                for (int y = 0; y < levelSize.y - 1; y++)
                {
                    if (tiles[x, y] == tileType.floor)
                    {
                        if (tiles[x + 1, y] == tileType.empty) tiles[x + 1, y] = tileType.wall;
                        if (tiles[x + 1, y + 1] == tileType.empty && spawnCornerWalls) tiles[x + 1, y + 1] = tileType.wall;
                        if (tiles[x, y + 1] == tileType.empty) tiles[x, y + 1] = tileType.wall;
                        if (tiles[x - 1, y + 1] == tileType.empty && spawnCornerWalls) tiles[x - 1, y + 1] = tileType.wall;
                        if (tiles[x - 1, y] == tileType.empty) tiles[x - 1, y] = tileType.wall;
                        if (tiles[x - 1, y - 1] == tileType.empty && spawnCornerWalls) tiles[x - 1, y - 1] = tileType.wall;
                        if (tiles[x, y - 1] == tileType.empty) tiles[x, y - 1] = tileType.wall;
                        if (tiles[x + 1, y - 1] == tileType.empty && spawnCornerWalls) tiles[x + 1, y - 1] = tileType.wall;
                    }
                }
            }

            RemoveIsolatedWalls();
            if (removeUnnaturalWalls) RemoveUnnaturalWalls();
        }


        private void RemoveIsolatedWalls()
        {
            for (int x = 0; x < levelSize.x - 1; x++)
            {
                for (int y = 0; y < levelSize.y - 1; y++)
                {
                    if (tiles[x, y] == tileType.wall && tiles[x + 1, y] == tileType.floor && tiles[x, y + 1] == tileType.floor && tiles[x - 1, y] == tileType.floor && tiles[x, y - 1] == tileType.floor) tiles[x, y] = tileType.floor;
                }
            }
        }


        private void RemoveUnnaturalWalls()
        {
            for (int x = 1; x < levelSizeCut.x - 1; x++)
            {
                for (int y = 1; y < levelSizeCut.y - 1; y++)
                {
                    if (tiles[x, y] == tileType.wall && tiles[x + 1, y] != tileType.empty && tiles[x + 1, y + 1] != tileType.empty && tiles[x, y + 1] != tileType.empty && tiles[x - 1, y + 1] != tileType.empty && tiles[x - 1, y] != tileType.empty && tiles[x - 1, y - 1] != tileType.empty && tiles[x, y - 1] != tileType.empty && tiles[x + 1, y - 1] != tileType.empty) tiles[x, y] = tileType.floor;
                }
            }
        }

        #endregion


        #region Overlay

        public void InstanciateFloorOverlay()
        {
            for (int x = 0; x < levelSize.x - 1; x++)
            {
                for (int y = 0; y < levelSize.y - 1; y++)
                {
                    if (patternFloor == patternType.perlinNoise && IsFloorTouchingWall(x,y)) CreatePerlinFloor(x, y);
                    else if (patternFloor == patternType.checker && IsFloorTouchingWall(x, y)) CreateCheckerFloor(x, y);
                    else if (patternFloor == patternType.wideChecker && IsFloorTouchingWall(x, y)) CreateWideCheckerFloor(x, y);
                    else if (patternFloor == patternType.lineLeft && IsFloorTouchingWall(x, y)) CreateLineLeftFloor(x, y);
                    else if (patternFloor == patternType.lineRight && IsFloorTouchingWall(x, y)) CreateLineRightFloor(x, y);
                }
            }
        }


        public void InstanciateWallOverlay()
        {
            for (int x = 0; x < levelSize.x - 1; x++)
            {
                for (int y = 0; y < levelSize.y - 1; y++)
                {
                    if (patternWall == patternType.perlinNoise && tiles[x, y] == tileType.wall) CreatePerlinWall(x, y);
                    else if (patternWall == patternType.checker && tiles[x, y] == tileType.wall) CreateCheckerWall(x, y);
                    else if (patternWall == patternType.wideChecker && tiles[x, y] == tileType.wall) CreateWideCheckerWall(x, y);
                    else if (patternWall == patternType.lineLeft && tiles[x, y] == tileType.wall) CreateLineLeftWall(x, y);
                    else if (patternWall == patternType.lineRight && tiles[x, y] == tileType.wall) CreateLineRightWall(x, y);
                }
            }
        }


        public void CreatePerlinFloor(int _posX, int _posY)
        {
            float value = Mathf.PerlinNoise(_posX * noiseScaleFloor.y + Random.Range(0f, 1f) * noiseScaleFloor.x, _posY * noiseScaleFloor.y + Random.Range(0f, 1f) * noiseScaleFloor.y);

            if (value > noiseCutoffFloor) overlayTiles[_posX, _posY] = overlayType.floorPattern;
            else if (drawFloorOverlayRandomTiles && Random.Range(0, 100) < randomFloorOverlayChance) overlayTiles[_posX, _posY] = overlayType.floorRandom;
        }


        public void CreatePerlinWall(int _posX, int _posY)
        {
            float value = Mathf.PerlinNoise(_posX * noiseScaleWall.y + Random.Range(0f, 1f) * noiseScaleWall.x, _posY * noiseScaleWall.y + Random.Range(0f, 1f) * noiseScaleWall.y);

            if (value > noiseCutoffWall && drawWallOverlayPatternTiles) overlayTiles[_posX, _posY] = overlayType.wallPattern;
            else if (drawWallOverlayRandomTiles && Random.Range(0, 100) < randomWallOverlayChance) overlayTiles[_posX, _posY] = overlayType.wallRandom;
        }


        public void CreateCheckerFloor(int _posX, int _posY)
        {
            float value = Mathf.PerlinNoise(_posX * noiseScaleFloor.y + Random.Range(0f, 1f) * noiseScaleFloor.x, _posY * noiseScaleFloor.y + Random.Range(0f, 1f) * noiseScaleFloor.y);

            if (value > noiseCutoffFloor && (_posX + _posY) % 2 == 0) overlayTiles[_posX, _posY] = overlayType.floorPattern;
            else if (drawFloorOverlayRandomTiles && Random.Range(0, 100) < randomFloorOverlayChance) overlayTiles[_posX, _posY] = overlayType.floorRandom;
        }


        public void CreateCheckerWall(int _posX, int _posY)
        {
            float value = Mathf.PerlinNoise(_posX * noiseScaleWall.y + Random.Range(0f, 1f) * noiseScaleWall.x, _posY * noiseScaleWall.y + Random.Range(0f, 1f) * noiseScaleWall.y);

            if (value > noiseCutoffWall && drawWallOverlayPatternTiles && (_posX + _posY) % 2 == 0) overlayTiles[_posX, _posY] = overlayType.wallPattern;
            else if (drawWallOverlayRandomTiles && Random.Range(0, 100) < randomWallOverlayChance) overlayTiles[_posX, _posY] = overlayType.wallRandom;
        }


        public void CreateWideCheckerFloor(int _posX, int _posY)
        {
            float value = Mathf.PerlinNoise(_posX * noiseScaleFloor.y + Random.Range(0f, 1f) * noiseScaleFloor.x, _posY * noiseScaleFloor.y + Random.Range(0f, 1f) * noiseScaleFloor.y);

            if (value > noiseCutoffFloor && (_posX + _posY) % 4 == 0 && _posX % 2 == 0 && _posY % 2 == 0) overlayTiles[_posX, _posY] = overlayType.floorPattern;
            else if (drawFloorOverlayRandomTiles && Random.Range(0, 100) < randomFloorOverlayChance) overlayTiles[_posX, _posY] = overlayType.floorRandom;
        }


        public void CreateWideCheckerWall(int _posX, int _posY)
        {
            float value = Mathf.PerlinNoise(_posX * noiseScaleWall.y + Random.Range(0f, 1f) * noiseScaleWall.x, _posY * noiseScaleWall.y + Random.Range(0f, 1f) * noiseScaleWall.y);

            if (value > noiseCutoffWall && drawWallOverlayPatternTiles && (_posX + _posY) % 4 == 0 && _posX % 2 == 0 && _posY % 2 == 0) overlayTiles[_posX, _posY] = overlayType.wallPattern;
            else if (drawWallOverlayRandomTiles && Random.Range(0, 100) < randomWallOverlayChance) overlayTiles[_posX, _posY] = overlayType.wallRandom;
        }


        public void CreateLineLeftFloor(int _posX, int _posY)
        {
            float value = Mathf.PerlinNoise(_posX * noiseScaleFloor.y + Random.Range(0f, 1f) * noiseScaleFloor.x, _posY * noiseScaleFloor.y + Random.Range(0f, 1f) * noiseScaleFloor.y);

            if (value > noiseCutoffFloor && (-_posX + _posY) % 3 == 0) overlayTiles[_posX, _posY] = overlayType.floorPattern;
            else if (drawFloorOverlayRandomTiles && Random.Range(0, 100) < randomFloorOverlayChance) overlayTiles[_posX, _posY] = overlayType.floorRandom;
        }


        public void CreateLineLeftWall(int _posX, int _posY)
        {
            float value = Mathf.PerlinNoise(_posX * noiseScaleWall.y + Random.Range(0f, 1f) * noiseScaleWall.x, _posY * noiseScaleWall.y + Random.Range(0f, 1f) * noiseScaleWall.y);

            if (value > noiseCutoffWall && drawWallOverlayPatternTiles && (-_posX + _posY) % 3 == 0) overlayTiles[_posX, _posY] = overlayType.wallPattern;
            else if (drawWallOverlayRandomTiles && Random.Range(0, 100) < randomWallOverlayChance) overlayTiles[_posX, _posY] = overlayType.wallRandom;
        }


        public void CreateLineRightFloor(int _posX, int _posY)
        {
            float value = Mathf.PerlinNoise(_posX * noiseScaleFloor.y + Random.Range(0f, 1f) * noiseScaleFloor.x, _posY * noiseScaleFloor.y + Random.Range(0f, 1f) * noiseScaleFloor.y);

            if (value > noiseCutoffFloor && (_posX + _posY) % 3 == 0) overlayTiles[_posX, _posY] = overlayType.floorPattern;
            else if (drawFloorOverlayRandomTiles && Random.Range(0, 100) < randomFloorOverlayChance) overlayTiles[_posX, _posY] = overlayType.floorRandom;
        }


        public void CreateLineRightWall(int _posX, int _posY)
        {
            float value = Mathf.PerlinNoise(_posX * noiseScaleWall.y + Random.Range(0f, 1f) * noiseScaleWall.x, _posY * noiseScaleWall.y + Random.Range(0f, 1f) * noiseScaleWall.y);

            if (value > noiseCutoffWall && drawWallOverlayPatternTiles && (_posX + _posY) % 3 == 0) overlayTiles[_posX, _posY] = overlayType.wallPattern;
            else if (drawWallOverlayRandomTiles && Random.Range(0, 100) < randomWallOverlayChance) overlayTiles[_posX, _posY] = overlayType.wallRandom;
        }


        public void InstanciateFloorRandomOverlay()
        {
            for (int x = 0; x < levelSize.x - 1; x++)
            {
                for (int y = 0; y < levelSize.y - 1; y++)
                {
                    if (Random.Range(0, 100) < randomFloorOverlayChance && tiles[x, y] == tileType.floor) overlayTiles[x, y] = overlayType.floorRandom;
                }
            }
        }


        public void InstanciateWallRandomOverlay()
        {
            for (int x = 0; x < levelSize.x - 1; x++)
            {
                for (int y = 0; y < levelSize.y - 1; y++)
                {
                    if (Random.Range(0, 100) < randomWallOverlayChance && tiles[x, y] == tileType.wall) overlayTiles[x, y] = overlayType.wallRandom;
                }
            }
        }

        #endregion


        #region Spawn 

        private void Spawn()
        {
            if (generation == genType.generateTile)
            {
                if (drawTilesOrientation) SpawnGridTilesOriented();
                else SpawnGridTiles();
            }
            else
            {
                if (drawTilesOrientation)
                {
                    if (fillAllTiles) SpawnAllTilesOriented();
                    else SpawnTilesOriented();
                }
                else SpawnTiles();

                RotateLevel();
            }
        }


        private void SpawnGridTilesOriented()
        {
            //references
            Tilemap emptyMap = new Tilemap();
            Tilemap overlayMap = new Tilemap();
            Tilemap floorMap = floorParent.GetComponent<Tilemap>();
            Tilemap wallMap = wallParent.GetComponent<Tilemap>();

            if (drawFloorOverlayPatternTiles || drawFloorOverlayRandomTiles || drawWallOverlayPatternTiles || drawWallOverlayRandomTiles) overlayMap = overlayParent.GetComponent<Tilemap>();
            if (drawEmptyTiles) emptyMap = emptyParent.GetComponent<Tilemap>();


            //instanciate
            for (int x = 0; x < levelSize.x; x++)
            {
                for (int y = 0; y < levelSize.y; y++)
                {
                    if (tiles[x, y] == tileType.floor)
                    {
                        bool wallTop = tiles[x, y + 1] == tileType.wall;
                        bool wallLeft = tiles[x - 1, y] == tileType.wall;
                        bool wallBottom = tiles[x, y - 1] == tileType.wall;
                        bool wallRight = tiles[x + 1, y] == tileType.wall;

                        bool wallTopLeft = tiles[x - 1, y + 1] == tileType.wall;
                        bool wallTopRight = tiles[x + 1, y + 1] == tileType.wall;
                        bool wallBottomLeft = tiles[x - 1, y - 1] == tileType.wall;
                        bool wallBottomRight = tiles[x + 1, y - 1] == tileType.wall;


                        //4 sides
                        if (!wallTop && !wallLeft && !wallBottom && !wallRight)
                        {
                            if(drawCorners)
                            {
                                //one side
                                if (wallTopLeft && !wallTopRight && !wallBottomLeft && !wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C1);
                                else if (!wallTopLeft && !wallTopRight && wallBottomLeft && !wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C2);
                                else if (!wallTopLeft && !wallTopRight && !wallBottomLeft && wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C3);
                                else if (!wallTopLeft && wallTopRight && !wallBottomLeft && !wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C4);

                                //2 sides
                                else if (wallTopLeft && wallTopRight && !wallBottomLeft && !wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C5);
                                else if (wallTopLeft && !wallTopRight && wallBottomLeft && !wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C6);
                                else if (!wallTopLeft && !wallTopRight && wallBottomLeft && wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C7);
                                else if (!wallTopLeft && wallTopRight && !wallBottomLeft && wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C8);
                                else if (!wallTopLeft && wallTopRight && wallBottomLeft && !wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C9);
                                else if (wallTopLeft && !wallTopRight && !wallBottomLeft && wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C10);

                                //3 sides
                                else if (wallTopLeft && wallTopRight && wallBottomLeft && !wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C11);
                                else if (wallTopLeft && !wallTopRight && wallBottomLeft && wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C12);
                                else if (!wallTopLeft && wallTopRight && wallBottomLeft && wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C13);
                                else if (wallTopLeft && wallTopRight && !wallBottomLeft && wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C14);
                                else if (wallTopLeft && wallTopRight && wallBottomLeft && wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C31);
                                else floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_1);
                            }
                            else floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_1);

                            if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                        }

                        //one side
                        else if (wallTop && !wallLeft && !wallBottom && !wallRight)
                        {
                            if (drawCorners)
                            {
                                if (wallBottomLeft && wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C17);
                                else if (wallBottomLeft) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C15);
                                else if (wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C16);
                                else floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_2);
                            }
                            else floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_2);

                            if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                        }
                        else if (!wallTop && wallLeft && !wallBottom && !wallRight)
                        {
                            if (drawCorners)
                            {
                                if (wallBottomRight && wallTopRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C20);
                                else if (wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C18);
                                else if (wallTopRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C19);
                                else floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_3);
                            }
                            else floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_3);

                            if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                        }
                        else if (!wallTop && !wallLeft && wallBottom && !wallRight)
                        {
                            if (drawCorners)
                            {
                                if (wallTopLeft && wallTopRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C23);
                                else if (wallTopLeft) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C21);
                                else if (wallTopRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C22);
                                else floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_4);
                            }
                            else floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_4);

                            if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                        }
                        else if (!wallTop && !wallLeft && !wallBottom && wallRight)
                        {
                            if (drawCorners)
                            {
                                if (wallTopLeft && wallBottomLeft) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C26);
                                else if (wallTopLeft) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C24);
                                else if (wallBottomLeft) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C25);
                                else floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_5);
                            }
                            else floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_5);

                            if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                        }

                        //2 sides
                        else if (wallTop && wallLeft && !wallBottom && !wallRight)
                        {
                            if (drawCorners && wallBottomRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C27);
                            else floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_6);

                            if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                        }
                        else if (!wallTop && wallLeft && wallBottom && !wallRight)
                        {
                            if (drawCorners && wallTopRight) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C28);
                            else floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_7);

                            if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                        }
                        else if (!wallTop && !wallLeft && wallBottom && wallRight)
                        {
                            if (drawCorners && wallTopLeft) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C29);
                            else floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_8);

                            if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                        }
                        else if (wallTop && !wallLeft && !wallBottom && wallRight)
                        {
                            if (drawCorners && wallBottomLeft) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_C30);
                            else floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_9);

                            if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                        }
                        else if (!wallTop && wallLeft && !wallBottom && wallRight)
                        {
                            floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_10);

                            if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                        }
                        else if (wallTop && !wallLeft && wallBottom && !wallRight)
                        {
                            floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_11);

                            if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                        }

                        //3 sides
                        else if (wallTop && wallLeft && !wallBottom && wallRight)
                        {
                            floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_12);

                            if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                        }
                        else if (wallTop && wallLeft && wallBottom && !wallRight)
                        {
                            floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_13);

                            if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                        }
                        else if (!wallTop && wallLeft && wallBottom && wallRight)
                        {
                            floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_14);

                            if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                        }
                        else if (wallTop && !wallLeft && wallBottom && wallRight)
                        {
                            floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_15);

                            if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                        }
                    }

                    else if (tiles[x, y] == tileType.wall)
                    {
                        bool floorTop = false;
                        bool floorLeft = false;
                        bool floorBottom = false;
                        bool floorRight = false;

                        bool floorTopLeft = false;
                        bool floorTopRight = false;
                        bool floorBottomLeft = false;
                        bool floorBottomRight = false;

                        if (y + 1 < levelSize.y) floorTop = tiles[x, y + 1] == tileType.floor;
                        if (x - 1 > 0) floorLeft = tiles[x - 1, y] == tileType.floor;
                        if (y - 1 > 0) floorBottom = tiles[x, y - 1] == tileType.floor;
                        if (x + 1 < levelSize.x) floorRight = tiles[x + 1, y] == tileType.floor;

                        if (x - 1 > 0 && y + 1 < levelSize.y) floorTopLeft = tiles[x - 1, y + 1] == tileType.floor;
                        if (x + 1 < levelSize.x && y + 1 < levelSize.y) floorTopRight = tiles[x + 1, y + 1] == tileType.floor;
                        if (x - 1 > 0 && y - 1 > 0) floorBottomLeft = tiles[x - 1, y - 1] == tileType.floor;
                        if (x + 1 < levelSize.x && y - 1 > 0) floorBottomRight = tiles[x + 1, y - 1] == tileType.floor;


                        //one side
                        if (floorTop && !floorLeft && !floorBottom && !floorRight)
                        {
                            if (drawCorners)
                            {
                                if (floorBottomLeft && floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C17);
                                else if (floorBottomLeft) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C15);
                                else if (floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C16);
                                else wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_2);
                            }
                            else wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_2);

                            if (overlayTiles[x, y] == overlayType.wallPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternWallTile_2);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomWallTile_2);
                        }
                        else if (!floorTop && floorLeft && !floorBottom && !floorRight)
                        {
                            if (drawCorners)
                            {
                                if (floorTopRight && floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C20);
                                else if (floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C18);
                                else if (floorTopRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C19);
                                else wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_3);
                            }
                            else wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_3);

                            if (overlayTiles[x, y] == overlayType.wallPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternWallTile_3);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomWallTile_3);
                        }
                        else if (!floorTop && !floorLeft && floorBottom && !floorRight)
                        {
                            if (drawCorners)
                            {
                                if (floorTopRight && floorTopLeft) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C23);
                                else if (floorTopLeft) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C21);
                                else if (floorTopRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C22);
                                else wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_4);
                            }
                            else wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_4);

                            if (overlayTiles[x, y] == overlayType.wallPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternWallTile_4);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomWallTile_4);
                        }
                        else if (!floorTop && !floorLeft && !floorBottom && floorRight)
                        {
                            if (drawCorners)
                            {
                                if (floorBottomLeft && floorTopLeft) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C26);
                                else if (floorTopLeft) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C24);
                                else if (floorBottomLeft) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C25);
                                else wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_5);
                            }
                            else wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_5);

                            if (overlayTiles[x, y] == overlayType.wallPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternWallTile_5);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomWallTile_5);
                        }

                        //2 sides
                        else if (floorTop && floorLeft && !floorBottom && !floorRight)
                        {
                            if (drawCorners && floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C27);
                            else wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_6);

                            if (overlayTiles[x, y] == overlayType.wallPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternWallTile_6);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomWallTile_6);
                        }
                        else if (!floorTop && floorLeft && floorBottom && !floorRight)
                        {
                            if (drawCorners && floorTopRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C28);
                            else wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_7);

                            if (overlayTiles[x, y] == overlayType.wallPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternWallTile_7);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomWallTile_7);
                        }
                        else if (!floorTop && !floorLeft && floorBottom && floorRight)
                        {
                            if (drawCorners && floorTopLeft) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C29);
                            else wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_8);

                            if (overlayTiles[x, y] == overlayType.wallPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternWallTile_8);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomWallTile_8);
                        }
                        else if (floorTop && !floorLeft && !floorBottom && floorRight)
                        {
                            if (drawCorners && floorBottomLeft) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C30);
                            else wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_9);

                            if (overlayTiles[x, y] == overlayType.wallPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternWallTile_9);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomWallTile_9);
                        }
                        else if (!floorTop && floorLeft && !floorBottom && floorRight)
                        {
                            wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_10);

                            if (overlayTiles[x, y] == overlayType.wallPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternWallTile_10);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomWallTile_10);
                        }
                        else if (floorTop && !floorLeft && floorBottom && !floorRight)
                        {
                            wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_11);

                            if (overlayTiles[x, y] == overlayType.wallPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternWallTile_11);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomWallTile_11);
                        }

                        //3 sides
                        else if (floorTop && floorLeft && !floorBottom && floorRight)
                        {
                            wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_12);

                            if (overlayTiles[x, y] == overlayType.wallPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternWallTile_12);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomWallTile_12);
                        }
                        else if (floorTop && floorLeft && floorBottom && !floorRight)
                        {
                            wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_13);

                            if (overlayTiles[x, y] == overlayType.wallPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternWallTile_13);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomWallTile_13);
                        }
                        else if (!floorTop && floorLeft && floorBottom && floorRight)
                        {
                            wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_14);

                            if (overlayTiles[x, y] == overlayType.wallPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternWallTile_14);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomWallTile_14);
                        }
                        else if (floorTop && !floorLeft && floorBottom && floorRight)
                        {
                            wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_15);

                            if (overlayTiles[x, y] == overlayType.wallPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternWallTile_15);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomWallTile_15);
                        }

                        //corner walls
                        else if (spawnCornerWalls)
                        {
                            if (drawCorners)
                            {
                                //one side
                                if (floorTopLeft && !floorTopRight && !floorBottomLeft && !floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C1);
                                else if (!floorTopLeft && !floorTopRight && floorBottomLeft && !floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C2);
                                else if (!floorTopLeft && !floorTopRight && !floorBottomLeft && floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C3);
                                else if (!floorTopLeft && floorTopRight && !floorBottomLeft && !floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C4);

                                //2 sides
                                else if (floorTopLeft && floorTopRight && !floorBottomLeft && !floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C5);
                                else if (floorTopLeft && !floorTopRight && floorBottomLeft && !floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C6);
                                else if (!floorTopLeft && !floorTopRight && floorBottomLeft && floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C7);
                                else if (!floorTopLeft && floorTopRight && !floorBottomLeft && floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C8);
                                else if (!floorTopLeft && floorTopRight && floorBottomLeft && !floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C9);
                                else if (floorTopLeft && !floorTopRight && !floorBottomLeft && floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C10);

                                //3 sides
                                else if (floorTopLeft && floorTopRight && floorBottomLeft && !floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C11);
                                else if (floorTopLeft && !floorTopRight && floorBottomLeft && floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C12);
                                else if (!floorTopLeft && floorTopRight && floorBottomLeft && floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C13);
                                else if (floorTopLeft && floorTopRight && !floorBottomLeft && floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C14);
                                else if (floorTopLeft && floorTopRight && floorBottomLeft && floorBottomRight) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_C31);
                                else wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_1);
                            }
                            else wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_1);
                        }
                        else if (drawEmptyTiles) emptyMap.SetTile(new Vector3Int(x, y, 0), emptyTile);
                    }

                    else if (drawEmptyTiles) emptyMap.SetTile(new Vector3Int(x, y, 0), emptyTile);
                }
            }
        }


        private void SpawnGridTiles()
        {
            //references
            Tilemap emptyMap = new Tilemap();
            Tilemap overlayMap = new Tilemap();
            Tilemap floorMap = floorParent.GetComponent<Tilemap>();
            Tilemap wallMap = wallParent.GetComponent<Tilemap>();

            if (drawFloorOverlayPatternTiles || drawFloorOverlayRandomTiles || drawWallOverlayPatternTiles || drawWallOverlayRandomTiles) overlayMap = overlayParent.GetComponent<Tilemap>();
            if (drawEmptyTiles) emptyMap = emptyParent.GetComponent<Tilemap>();


            //instanciate
            for (int x = 0; x < levelSize.x; x++)
            {
                for (int y = 0; y < levelSize.y; y++)
                {
                    if (tiles[x, y] == tileType.floor) floorMap.SetTile(new Vector3Int(x, y, 0), floorTile_1);
                    else if (tiles[x, y] == tileType.wall) wallMap.SetTile(new Vector3Int(x, y, 0), wallTile_1);
                    else if (drawEmptyTiles) emptyMap.SetTile(new Vector3Int(x, y, 0), emptyTile);

                    if (overlayTiles[x, y] == overlayType.floorPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternFloorTile);
                    else if (overlayTiles[x, y] == overlayType.floorRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomFloorTile);
                    else if (overlayTiles[x, y] == overlayType.wallPattern) overlayMap.SetTile(new Vector3Int(x, y, 0), patternWallTile_1);
                    else if (overlayTiles[x, y] == overlayType.wallRandom) overlayMap.SetTile(new Vector3Int(x, y, 0), randomWallTile_1);
                }
            }
        }


        private void SpawnAllTilesOriented()
        {
            for (int x = 0; x < levelSize.x; x++)
            {
                for (int y = 0; y < levelSize.y; y++)
                {
                    if (tiles[x, y] == tileType.floor)
                    {
                        bool wallTop = tiles[x, y + 1] == tileType.wall;
                        bool wallLeft = tiles[x - 1, y] == tileType.wall;
                        bool wallBottom = tiles[x, y - 1] == tileType.wall;
                        bool wallRight = tiles[x + 1, y] == tileType.wall;

                        bool wallTopLeft = tiles[x - 1, y + 1] == tileType.wall;
                        bool wallTopRight = tiles[x + 1, y + 1] == tileType.wall;
                        bool wallBottomLeft = tiles[x - 1, y - 1] == tileType.wall;
                        bool wallBottomRight = tiles[x + 1, y - 1] == tileType.wall;


                        //4 sides
                        if (!wallTop && !wallLeft && !wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners)
                                {
                                    //one side
                                    if (wallTopLeft && !wallTopRight && !wallBottomLeft && !wallBottomRight) SpawnTile(floorTileObj_C1, floorParent.transform, x, y);
                                    else if (!wallTopLeft && !wallTopRight && wallBottomLeft && !wallBottomRight) SpawnTile(floorTileObj_C2, floorParent.transform, x, y);
                                    else if (!wallTopLeft && !wallTopRight && !wallBottomLeft && wallBottomRight) SpawnTile(floorTileObj_C3, floorParent.transform, x, y);
                                    else if (!wallTopLeft && wallTopRight && !wallBottomLeft && !wallBottomRight) SpawnTile(floorTileObj_C4, floorParent.transform, x, y);

                                    //2 sides
                                    else if (wallTopLeft && wallTopRight && !wallBottomLeft && !wallBottomRight) SpawnTile(floorTileObj_C5, floorParent.transform, x, y);
                                    else if (wallTopLeft && !wallTopRight && wallBottomLeft && !wallBottomRight) SpawnTile(floorTileObj_C6, floorParent.transform, x, y);
                                    else if (!wallTopLeft && !wallTopRight && wallBottomLeft && wallBottomRight) SpawnTile(floorTileObj_C7, floorParent.transform, x, y);
                                    else if (!wallTopLeft && wallTopRight && !wallBottomLeft && wallBottomRight) SpawnTile(floorTileObj_C8, floorParent.transform, x, y);
                                    else if (!wallTopLeft && wallTopRight && wallBottomLeft && !wallBottomRight) SpawnTile(floorTileObj_C9, floorParent.transform, x, y);
                                    else if (wallTopLeft && !wallTopRight && !wallBottomLeft && wallBottomRight) SpawnTile(floorTileObj_C10, floorParent.transform, x, y);

                                    //3 sides
                                    else if (wallTopLeft && wallTopRight && wallBottomLeft && !wallBottomRight) SpawnTile(floorTileObj_C11, floorParent.transform, x, y);
                                    else if (wallTopLeft && !wallTopRight && wallBottomLeft && wallBottomRight) SpawnTile(floorTileObj_C12, floorParent.transform, x, y);
                                    else if (!wallTopLeft && wallTopRight && wallBottomLeft && wallBottomRight) SpawnTile(floorTileObj_C13, floorParent.transform, x, y);
                                    else if (wallTopLeft && wallTopRight && !wallBottomLeft && wallBottomRight) SpawnTile(floorTileObj_C14, floorParent.transform, x, y);
                                    else if (wallTopLeft && wallTopRight && wallBottomLeft && wallBottomRight) SpawnTile(floorTileObj_C31, floorParent.transform, x, y);
                                    else SpawnTile(floorTileObj_1, floorParent.transform, x, y);
                                }
                                else SpawnTile(floorTileObj_1, floorParent.transform, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }

                        //one side
                        else if (wallTop && !wallLeft && !wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners)
                                {
                                    if (wallBottomLeft && wallBottomRight) SpawnTile(floorTileObj_C17, floorParent.transform, x, y);
                                    else if (wallBottomLeft) SpawnTile(floorTileObj_C15, floorParent.transform, x, y);
                                    else if (wallBottomRight) SpawnTile(floorTileObj_C16, floorParent.transform, x, y);
                                    else SpawnTile(floorTileObj_2, floorParent.transform, x, y);
                                }
                                else SpawnTile(floorTileObj_2, floorParent.transform, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (!wallTop && wallLeft && !wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners)
                                {
                                    if (wallBottomRight && wallTopRight) SpawnTile(floorTileObj_C20, floorParent.transform, x, y);
                                    else if (wallBottomRight) SpawnTile(floorTileObj_C18, floorParent.transform, x, y);
                                    else if (wallTopRight) SpawnTile(floorTileObj_C19, floorParent.transform, x, y);
                                    else SpawnTile(floorTileObj_3, floorParent.transform, x, y);
                                }
                                else SpawnTile(floorTileObj_3, floorParent.transform, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (!wallTop && !wallLeft && wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners)
                                {
                                    if (wallTopLeft && wallTopRight) SpawnTile(floorTileObj_C23, floorParent.transform, x, y);
                                    else if (wallTopLeft) SpawnTile(floorTileObj_C21, floorParent.transform, x, y);
                                    else if (wallTopRight) SpawnTile(floorTileObj_C22, floorParent.transform, x, y);
                                    else SpawnTile(floorTileObj_4, floorParent.transform, x, y);
                                }
                                else SpawnTile(floorTileObj_4, floorParent.transform, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (!wallTop && !wallLeft && !wallBottom && wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners)
                                {
                                    if (wallTopLeft && wallBottomLeft) SpawnTile(floorTileObj_C26, floorParent.transform, x, y);
                                    else if (wallTopLeft) SpawnTile(floorTileObj_C24, floorParent.transform, x, y);
                                    else if (wallBottomLeft) SpawnTile(floorTileObj_C25, floorParent.transform, x, y);
                                    else SpawnTile(floorTileObj_5, floorParent.transform, x, y);
                                }
                                else SpawnTile(floorTileObj_5, floorParent.transform, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }

                        //2 sides
                        else if (wallTop && wallLeft && !wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if(drawCorners && wallBottomRight) SpawnTile(floorTileObj_C27, floorParent.transform, x, y);
                                else SpawnTile(floorTileObj_6, floorParent.transform, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (!wallTop && wallLeft && wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners && wallTopRight) SpawnTile(floorTileObj_C28, floorParent.transform, x, y);
                                else SpawnTile(floorTileObj_7, floorParent.transform, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (!wallTop && !wallLeft && wallBottom && wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners && wallTopLeft) SpawnTile(floorTileObj_C29, floorParent.transform, x, y);
                                else SpawnTile(floorTileObj_8, floorParent.transform, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (wallTop && !wallLeft && !wallBottom && wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners && wallBottomLeft) SpawnTile(floorTileObj_C30, floorParent.transform, x, y);
                                else SpawnTile(floorTileObj_9, floorParent.transform, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (!wallTop && wallLeft && !wallBottom && wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom)) SpawnTile(floorTileObj_10, floorParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (wallTop && !wallLeft && wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom)) SpawnTile(floorTileObj_11, floorParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }

                        //3 sides
                        else if (wallTop && wallLeft && !wallBottom && wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom)) SpawnTile(floorTileObj_12, floorParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (wallTop && wallLeft && wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom)) SpawnTile(floorTileObj_13, floorParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (!wallTop && wallLeft && wallBottom && wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom)) SpawnTile(floorTileObj_14, floorParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (wallTop && !wallLeft && wallBottom && wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom)) SpawnTile(floorTileObj_15, floorParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                    }

                    else if (tiles[x, y] == tileType.wall)
                    {
                        bool floorTop = false;
                        bool floorLeft = false;
                        bool floorBottom = false;
                        bool floorRight = false;

                        bool floorTopLeft = false;
                        bool floorTopRight = false;
                        bool floorBottomLeft = false;
                        bool floorBottomRight = false;

                        if (y + 1 < levelSize.y) floorTop = tiles[x, y + 1] == tileType.floor;
                        if (x - 1 > 0) floorLeft = tiles[x - 1, y] == tileType.floor;
                        if (y - 1 > 0) floorBottom = tiles[x, y - 1] == tileType.floor;
                        if (x + 1 < levelSize.x) floorRight = tiles[x + 1, y] == tileType.floor;

                        if (x - 1 > 0 && y + 1 < levelSize.y) floorTopLeft = tiles[x - 1, y + 1] == tileType.floor;
                        if (x + 1 < levelSize.x && y + 1 < levelSize.y) floorTopRight = tiles[x + 1, y + 1] == tileType.floor;
                        if (x - 1 > 0 && y - 1 > 0) floorBottomLeft = tiles[x - 1, y - 1] == tileType.floor;
                        if (x + 1 < levelSize.x && y - 1 > 0) floorBottomRight = tiles[x + 1, y - 1] == tileType.floor;


                        //one side
                        if (floorTop && !floorLeft && !floorBottom && !floorRight)
                        {
                            if(drawCorners)
                            {
                                if (floorBottomLeft && floorBottomRight) SpawnTile(wallTileObj_C17, wallParent.transform, x, y);
                                else if (floorBottomLeft) SpawnTile(wallTileObj_C15, wallParent.transform, x, y);
                                else if (floorBottomRight) SpawnTile(wallTileObj_C16, wallParent.transform, x, y);
                                else SpawnTile(wallTileObj_2, wallParent.transform, x, y);
                            }
                            else SpawnTile(wallTileObj_2, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_2, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_2, overlayParent.transform, x, y);
                        }
                        else if (!floorTop && floorLeft && !floorBottom && !floorRight)
                        {
                            if (drawCorners)
                            {
                                if (floorTopRight && floorBottomRight) SpawnTile(wallTileObj_C20, wallParent.transform, x, y);
                                else if (floorBottomRight) SpawnTile(wallTileObj_C18, wallParent.transform, x, y);
                                else if (floorTopRight) SpawnTile(wallTileObj_C19, wallParent.transform, x, y);
                                else SpawnTile(wallTileObj_3, wallParent.transform, x, y);
                            }
                            else SpawnTile(wallTileObj_3, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_3, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_3, overlayParent.transform, x, y);
                        }
                        else if (!floorTop && !floorLeft && floorBottom && !floorRight)
                        {
                            if (drawCorners)
                            {
                                if (floorTopRight && floorTopLeft) SpawnTile(wallTileObj_C23, wallParent.transform, x, y);
                                else if (floorTopLeft) SpawnTile(wallTileObj_C21, wallParent.transform, x, y);
                                else if (floorTopRight) SpawnTile(wallTileObj_C22, wallParent.transform, x, y);
                                else SpawnTile(wallTileObj_4, wallParent.transform, x, y);
                            }
                            else SpawnTile(wallTileObj_4, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_4, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_4, overlayParent.transform, x, y);
                        }
                        else if (!floorTop && !floorLeft && !floorBottom && floorRight)
                        {
                            if (drawCorners)
                            {
                                if (floorBottomLeft && floorTopLeft) SpawnTile(wallTileObj_C26, wallParent.transform, x, y);
                                else if (floorTopLeft) SpawnTile(wallTileObj_C24, wallParent.transform, x, y);
                                else if (floorBottomLeft) SpawnTile(wallTileObj_C25, wallParent.transform, x, y);
                                else SpawnTile(wallTileObj_5, wallParent.transform, x, y);
                            }
                            else SpawnTile(wallTileObj_5, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_5, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_5, overlayParent.transform, x, y);
                        }

                        //2 sides
                        else if (floorTop && floorLeft && !floorBottom && !floorRight)
                        {
                            if(drawCorners && floorBottomRight) SpawnTile(wallTileObj_C27, wallParent.transform, x, y);
                            else SpawnTile(wallTileObj_6, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_6, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_6, overlayParent.transform, x, y);
                        }
                        else if (!floorTop && floorLeft && floorBottom && !floorRight)
                        {
                            if (drawCorners && floorTopRight) SpawnTile(wallTileObj_C28, wallParent.transform, x, y);
                            else SpawnTile(wallTileObj_7, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_7, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_7, overlayParent.transform, x, y);
                        }
                        else if (!floorTop && !floorLeft && floorBottom && floorRight)
                        {
                            if (drawCorners && floorTopLeft) SpawnTile(wallTileObj_C29, wallParent.transform, x, y);
                            else SpawnTile(wallTileObj_8, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_8, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_8, overlayParent.transform, x, y);
                        }
                        else if (floorTop && !floorLeft && !floorBottom && floorRight)
                        {
                            if (drawCorners && floorBottomLeft) SpawnTile(wallTileObj_C30, wallParent.transform, x, y);
                            else SpawnTile(wallTileObj_9, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_9, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_9, overlayParent.transform, x, y);
                        }
                        else if (!floorTop && floorLeft && !floorBottom && floorRight)
                        {
                            SpawnTile(wallTileObj_10, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_10, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_10, overlayParent.transform, x, y);
                        }
                        else if (floorTop && !floorLeft && floorBottom && !floorRight)
                        {
                            SpawnTile(wallTileObj_11, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_11, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_11, overlayParent.transform, x, y);
                        }

                        //3 sides
                        else if (floorTop && floorLeft && !floorBottom && floorRight)
                        {
                            SpawnTile(wallTileObj_12, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_12, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_12, overlayParent.transform, x, y);
                        }
                        else if (floorTop && floorLeft && floorBottom && !floorRight)
                        {
                            SpawnTile(wallTileObj_13, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_13, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_13, overlayParent.transform, x, y);
                        }
                        else if (!floorTop && floorLeft && floorBottom && floorRight)
                        {
                            SpawnTile(wallTileObj_14, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_14, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_14, overlayParent.transform, x, y);
                        }
                        else if (floorTop && !floorLeft && floorBottom && floorRight)
                        {
                            SpawnTile(wallTileObj_15, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_15, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_15, overlayParent.transform, x, y);
                        }

                        //corner walls
                        else if (spawnCornerWalls)
                        {
                            if (drawCorners)
                            {
                                //one side
                                if (floorTopLeft && !floorTopRight && !floorBottomLeft && !floorBottomRight) SpawnTile(wallTileObj_C1, wallParent.transform, x, y);
                                else if (!floorTopLeft && !floorTopRight && floorBottomLeft && !floorBottomRight) SpawnTile(wallTileObj_C2, wallParent.transform, x, y);
                                else if (!floorTopLeft && !floorTopRight && !floorBottomLeft && floorBottomRight) SpawnTile(wallTileObj_C3, wallParent.transform, x, y);
                                else if (!floorTopLeft && floorTopRight && !floorBottomLeft && !floorBottomRight) SpawnTile(wallTileObj_C4, wallParent.transform, x, y);

                                //2 sides
                                else if (floorTopLeft && floorTopRight && !floorBottomLeft && !floorBottomRight) SpawnTile(wallTileObj_C5, wallParent.transform, x, y);
                                else if (floorTopLeft && !floorTopRight && floorBottomLeft && !floorBottomRight) SpawnTile(wallTileObj_C6, wallParent.transform, x, y);
                                else if (!floorTopLeft && !floorTopRight && floorBottomLeft && floorBottomRight) SpawnTile(wallTileObj_C7, wallParent.transform, x, y);
                                else if (!floorTopLeft && floorTopRight && !floorBottomLeft && floorBottomRight) SpawnTile(wallTileObj_C8, wallParent.transform, x, y);
                                else if (!floorTopLeft && floorTopRight && floorBottomLeft && !floorBottomRight) SpawnTile(wallTileObj_C9, wallParent.transform, x, y);
                                else if (floorTopLeft && !floorTopRight && !floorBottomLeft && floorBottomRight) SpawnTile(wallTileObj_C10, wallParent.transform, x, y);

                                //3 sides
                                else if (floorTopLeft && floorTopRight && floorBottomLeft && !floorBottomRight) SpawnTile(wallTileObj_C11, wallParent.transform, x, y);
                                else if (floorTopLeft && !floorTopRight && floorBottomLeft && floorBottomRight) SpawnTile(wallTileObj_C12, wallParent.transform, x, y);
                                else if (!floorTopLeft && floorTopRight && floorBottomLeft && floorBottomRight) SpawnTile(wallTileObj_C13, wallParent.transform, x, y);
                                else if (floorTopLeft && floorTopRight && !floorBottomLeft && floorBottomRight) SpawnTile(wallTileObj_C14, wallParent.transform, x, y);
                                else if (floorTopLeft && floorTopRight && floorBottomLeft && floorBottomRight) SpawnTile(wallTileObj_C31, wallParent.transform, x, y);
                                else SpawnTile(wallTileObj_1, wallParent.transform, x, y);
                            }
                            else SpawnTile(wallTileObj_1, wallParent.transform, x, y);
                        }
                        else if (drawEmptyTiles) SpawnTile(emptyTileObj, emptyParent.transform, x, y);
                    }

                    else if (drawEmptyTiles) SpawnTile(emptyTileObj, emptyParent.transform, x, y);
                }
            }
        }


        private void SpawnTilesOriented()
        {
            for (int x = 0; x < levelSize.x; x++)
            {
                for (int y = 0; y < levelSize.y; y++)
                {
                    if (tiles[x, y] == tileType.floor)
                    {
                        bool wallTop = tiles[x, y + 1] == tileType.wall;
                        bool wallLeft = tiles[x - 1, y] == tileType.wall;
                        bool wallBottom = tiles[x, y - 1] == tileType.wall;
                        bool wallRight = tiles[x + 1, y] == tileType.wall;

                        bool wallTopLeft = tiles[x - 1, y + 1] == tileType.wall;
                        bool wallTopRight = tiles[x + 1, y + 1] == tileType.wall;
                        bool wallBottomLeft = tiles[x - 1, y - 1] == tileType.wall;
                        bool wallBottomRight = tiles[x + 1, y - 1] == tileType.wall;


                        //4 sides
                        if (!wallTop && !wallLeft && !wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners)
                                {
                                    //one side
                                    if (wallTopLeft && !wallTopRight && !wallBottomLeft && !wallBottomRight) SpawnTile(floorTileObj_C1, floorParent.transform, x, y);
                                    else if (!wallTopLeft && !wallTopRight && wallBottomLeft && !wallBottomRight) SpawnTileRotated(floorTileObj_C1, floorParent.transform, -90f, x, y);
                                    else if (!wallTopLeft && !wallTopRight && !wallBottomLeft && wallBottomRight) SpawnTileRotated(floorTileObj_C1, floorParent.transform, 180f, x, y);
                                    else if (!wallTopLeft && wallTopRight && !wallBottomLeft && !wallBottomRight) SpawnTileRotated(floorTileObj_C1, floorParent.transform, 90f, x, y);

                                    //2 sides
                                    else if (wallTopLeft && wallTopRight && !wallBottomLeft && !wallBottomRight) SpawnTile(floorTileObj_C5, floorParent.transform, x, y);
                                    else if (wallTopLeft && !wallTopRight && wallBottomLeft && !wallBottomRight) SpawnTileRotated(floorTileObj_C5, floorParent.transform, -90f, x, y);
                                    else if (!wallTopLeft && !wallTopRight && wallBottomLeft && wallBottomRight) SpawnTileRotated(floorTileObj_C5, floorParent.transform, 180f, x, y);
                                    else if (!wallTopLeft && wallTopRight && !wallBottomLeft && wallBottomRight) SpawnTileRotated(floorTileObj_C5, floorParent.transform, 90f, x, y);
                                    else if (!wallTopLeft && wallTopRight && wallBottomLeft && !wallBottomRight) SpawnTile(floorTileObj_C9, floorParent.transform, x, y);
                                    else if (wallTopLeft && !wallTopRight && !wallBottomLeft && wallBottomRight) SpawnTileRotated(floorTileObj_C9, floorParent.transform, -90f, x, y);

                                    //3 sides
                                    else if (wallTopLeft && wallTopRight && wallBottomLeft && !wallBottomRight) SpawnTile(floorTileObj_C11, floorParent.transform, x, y);
                                    else if (wallTopLeft && !wallTopRight && wallBottomLeft && wallBottomRight) SpawnTileRotated(floorTileObj_C11, floorParent.transform, -90f, x, y);
                                    else if (!wallTopLeft && wallTopRight && wallBottomLeft && wallBottomRight) SpawnTileRotated(floorTileObj_C11, floorParent.transform, 180f, x, y);
                                    else if (wallTopLeft && wallTopRight && !wallBottomLeft && wallBottomRight) SpawnTileRotated(floorTileObj_C11, floorParent.transform, 90f, x, y);
                                    else if (wallTopLeft && wallTopRight && wallBottomLeft && wallBottomRight) SpawnTile(floorTileObj_C31, floorParent.transform, x, y);
                                    else SpawnTile(floorTileObj_1, floorParent.transform, x, y);
                                }
                                else SpawnTile(floorTileObj_1, floorParent.transform, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }

                        //one side
                        else if (wallTop && !wallLeft && !wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners)
                                {
                                    if (wallBottomLeft && wallBottomRight) SpawnTile(floorTileObj_C17, floorParent.transform, x, y);
                                    else if (wallBottomLeft) SpawnTile(floorTileObj_C15, floorParent.transform, x, y);
                                    else if (wallBottomRight) SpawnTile(floorTileObj_C16, floorParent.transform, x, y);
                                    else SpawnTile(floorTileObj_2, floorParent.transform, x, y);
                                }
                                else SpawnTile(floorTileObj_2, floorParent.transform, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (!wallTop && wallLeft && !wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners)
                                {
                                    if (wallBottomRight && wallTopRight) SpawnTileRotated(floorTileObj_C17, floorParent.transform, -90f, x, y);
                                    else if (wallBottomRight) SpawnTileRotated(floorTileObj_C15, floorParent.transform, -90f, x, y);
                                    else if (wallTopRight) SpawnTileRotated(floorTileObj_C16, floorParent.transform, -90f, x, y);
                                    else SpawnTileRotated(floorTileObj_2, floorParent.transform, -90f, x, y);
                                }
                                else SpawnTileRotated(floorTileObj_2, floorParent.transform, -90f, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (!wallTop && !wallLeft && wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners)
                                {
                                    if (wallTopLeft && wallTopRight) SpawnTileRotated(floorTileObj_C17, floorParent.transform, 180f, x, y);
                                    else if (wallTopLeft) SpawnTileRotated(floorTileObj_C15, floorParent.transform, 180f, x, y);
                                    else if (wallTopRight) SpawnTileRotated(floorTileObj_C16, floorParent.transform, 180f, x, y);
                                    else SpawnTileRotated(floorTileObj_2, floorParent.transform, 180f, x, y);
                                }
                                else SpawnTileRotated(floorTileObj_2, floorParent.transform, 180f, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (!wallTop && !wallLeft && !wallBottom && wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners)
                                {
                                    if (wallTopLeft && wallBottomLeft) SpawnTileRotated(floorTileObj_C17, floorParent.transform, 90f, x, y);
                                    else if (wallTopLeft) SpawnTileRotated(floorTileObj_C15, floorParent.transform, 90f, x, y);
                                    else if (wallBottomLeft) SpawnTileRotated(floorTileObj_C16, floorParent.transform, 90f, x, y);
                                    else SpawnTileRotated(floorTileObj_2, floorParent.transform, 90f, x, y);
                                }
                                else SpawnTileRotated(floorTileObj_2, floorParent.transform, 90f, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }

                        //2 sides
                        else if (wallTop && wallLeft && !wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners && wallBottomRight) SpawnTile(floorTileObj_C27, floorParent.transform, x, y);
                                else SpawnTile(floorTileObj_6, floorParent.transform, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (!wallTop && wallLeft && wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners && wallTopRight) SpawnTileRotated(floorTileObj_C27, floorParent.transform, -90f, x, y);
                                else SpawnTileRotated(floorTileObj_6, floorParent.transform, -90f, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (!wallTop && !wallLeft && wallBottom && wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners && wallTopLeft) SpawnTileRotated(floorTileObj_C27, floorParent.transform, 180f, x, y);
                                else SpawnTileRotated(floorTileObj_6, floorParent.transform, 180f, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (wallTop && !wallLeft && !wallBottom && wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))
                            {
                                if (drawCorners && wallBottomLeft) SpawnTileRotated(floorTileObj_C27, floorParent.transform, 90f, x, y);
                                else SpawnTileRotated(floorTileObj_6, floorParent.transform, 90f, x, y);
                            }

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (!wallTop && wallLeft && !wallBottom && wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom)) SpawnTile(floorTileObj_10, floorParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (wallTop && !wallLeft && wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom)) SpawnTileRotated(floorTileObj_10, floorParent.transform, -90f, x, y);

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }

                        //3 sides
                        else if (wallTop && wallLeft && !wallBottom && wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom)) SpawnTile(floorTileObj_12, floorParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (wallTop && wallLeft && wallBottom && !wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom)) SpawnTileRotated(floorTileObj_12, floorParent.transform, -90f, x, y);

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (!wallTop && wallLeft && wallBottom && wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom)) SpawnTileRotated(floorTileObj_12, floorParent.transform, 180f, x, y);

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                        else if (wallTop && !wallLeft && wallBottom && wallRight)
                        {
                            if (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom)) SpawnTileRotated(floorTileObj_12, floorParent.transform, 90f, x, y);

                            if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                        }
                    }

                    else if (tiles[x, y] == tileType.wall)
                    {
                        bool floorTop = false;
                        bool floorLeft = false;
                        bool floorBottom = false;
                        bool floorRight = false;

                        bool floorTopLeft = false;
                        bool floorTopRight = false;
                        bool floorBottomLeft = false;
                        bool floorBottomRight = false;

                        if (y + 1 < levelSize.y) floorTop = tiles[x, y + 1] == tileType.floor;
                        if (x - 1 > 0) floorLeft = tiles[x - 1, y] == tileType.floor;
                        if (y - 1 > 0) floorBottom = tiles[x, y - 1] == tileType.floor;
                        if (x + 1 < levelSize.x) floorRight = tiles[x + 1, y] == tileType.floor;

                        if (x - 1 > 0 && y + 1 < levelSize.y) floorTopLeft = tiles[x - 1, y + 1] == tileType.floor;
                        if (x + 1 < levelSize.x && y + 1 < levelSize.y) floorTopRight = tiles[x + 1, y + 1] == tileType.floor;
                        if (x - 1 > 0 && y - 1 > 0) floorBottomLeft = tiles[x - 1, y - 1] == tileType.floor;
                        if (x + 1 < levelSize.x && y - 1 > 0) floorBottomRight = tiles[x + 1, y - 1] == tileType.floor;


                        //one side
                        if (floorTop && !floorLeft && !floorBottom && !floorRight)
                        {
                            if (drawCorners)
                            {
                                if (floorBottomLeft && floorBottomRight) SpawnTile(wallTileObj_C17, wallParent.transform, x, y);
                                else if (floorBottomLeft) SpawnTile(wallTileObj_C15, wallParent.transform, x, y);
                                else if (floorBottomRight) SpawnTile(wallTileObj_C16, wallParent.transform, x, y);
                                else SpawnTile(wallTileObj_2, wallParent.transform, x, y);
                            }
                            else SpawnTile(wallTileObj_2, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_2, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_2, overlayParent.transform, x, y);
                        }
                        else if (!floorTop && floorLeft && !floorBottom && !floorRight)
                        {
                            if (drawCorners)
                            {
                                if (floorTopRight && floorBottomRight) SpawnTileRotated(wallTileObj_C17, wallParent.transform, -90f, x, y);
                                else if (floorBottomRight) SpawnTileRotated(wallTileObj_C15, wallParent.transform, -90f, x, y);
                                else if (floorTopRight) SpawnTileRotated(wallTileObj_C16, wallParent.transform, -90f, x, y);
                                else SpawnTileRotated(wallTileObj_2, wallParent.transform, -90f, x, y);
                            }
                            else SpawnTileRotated(wallTileObj_2, wallParent.transform, -90f, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_3, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_3, overlayParent.transform, x, y);
                        }
                        else if (!floorTop && !floorLeft && floorBottom && !floorRight)
                        {
                            if (drawCorners)
                            {
                                if (floorTopRight && floorTopLeft) SpawnTileRotated(wallTileObj_C17, wallParent.transform, 180f, x, y);
                                else if (floorTopLeft) SpawnTileRotated(wallTileObj_C15, wallParent.transform, 180f, x, y);
                                else if (floorTopRight) SpawnTileRotated(wallTileObj_C16, wallParent.transform, 180f, x, y);
                                else SpawnTileRotated(wallTileObj_2, wallParent.transform, 180f, x, y);
                            }
                            else SpawnTileRotated(wallTileObj_2, wallParent.transform, 180f, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_4, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_4, overlayParent.transform, x, y);
                        }
                        else if (!floorTop && !floorLeft && !floorBottom && floorRight)
                        {
                            if (drawCorners)
                            {
                                if (floorBottomLeft && floorTopLeft) SpawnTileRotated(wallTileObj_C17, wallParent.transform, 90f, x, y);
                                else if (floorTopLeft) SpawnTileRotated(wallTileObj_C15, wallParent.transform, 90f, x, y);
                                else if (floorBottomLeft) SpawnTileRotated(wallTileObj_C16, wallParent.transform, 90f, x, y);
                                else SpawnTileRotated(wallTileObj_2, wallParent.transform, 90f, x, y);
                            }
                            else SpawnTileRotated(wallTileObj_2, wallParent.transform, 90f, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_5, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_5, overlayParent.transform, x, y);
                        }

                        //2 sides
                        else if (floorTop && floorLeft && !floorBottom && !floorRight)
                        {
                            if (drawCorners && floorBottomRight) SpawnTile(wallTileObj_C27, wallParent.transform, x, y);
                            else SpawnTile(wallTileObj_6, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_6, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_6, overlayParent.transform, x, y);
                        }
                        else if (!floorTop && floorLeft && floorBottom && !floorRight)
                        {
                            if (drawCorners && floorTopRight) SpawnTileRotated(wallTileObj_C27, wallParent.transform, -90f, x, y);
                            else SpawnTileRotated(wallTileObj_6, wallParent.transform, -90f, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_7, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_7, overlayParent.transform, x, y);
                        }
                        else if (!floorTop && !floorLeft && floorBottom && floorRight)
                        {
                            if (drawCorners && floorTopLeft) SpawnTileRotated(wallTileObj_C27, wallParent.transform, 180f, x, y);
                            else SpawnTileRotated(wallTileObj_6, wallParent.transform, 180f, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_8, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_8, overlayParent.transform, x, y);
                        }
                        else if (floorTop && !floorLeft && !floorBottom && floorRight)
                        {
                            if (drawCorners && floorBottomLeft) SpawnTileRotated(wallTileObj_C27, wallParent.transform, 90f, x, y);
                            else SpawnTileRotated(wallTileObj_6, wallParent.transform, 90f, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_9, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_9, overlayParent.transform, x, y);
                        }
                        else if (!floorTop && floorLeft && !floorBottom && floorRight)
                        {
                            SpawnTile(wallTileObj_10, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_10, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_10, overlayParent.transform, x, y);
                        }
                        else if (floorTop && !floorLeft && floorBottom && !floorRight)
                        {
                            SpawnTileRotated(wallTileObj_10, wallParent.transform, -90f, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_11, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_11, overlayParent.transform, x, y);
                        }

                        //3 sides
                        else if (floorTop && floorLeft && !floorBottom && floorRight)
                        {
                            SpawnTile(wallTileObj_12, wallParent.transform, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_12, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_12, overlayParent.transform, x, y);
                        }
                        else if (floorTop && floorLeft && floorBottom && !floorRight)
                        {
                            SpawnTileRotated(wallTileObj_12, wallParent.transform, -90f, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_13, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_13, overlayParent.transform, x, y);
                        }
                        else if (!floorTop && floorLeft && floorBottom && floorRight)
                        {
                            SpawnTileRotated(wallTileObj_12, wallParent.transform, 180f, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_14, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_14, overlayParent.transform, x, y);
                        }
                        else if (floorTop && !floorLeft && floorBottom && floorRight)
                        {
                            SpawnTileRotated(wallTileObj_12, wallParent.transform, 90f, x, y);

                            if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_15, overlayParent.transform, x, y);
                            else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_15, overlayParent.transform, x, y);
                        }

                        //corner walls
                        else if (spawnCornerWalls)
                        {
                            if (drawCorners)
                            {
                                //one side
                                if (floorTopLeft && !floorTopRight && !floorBottomLeft && !floorBottomRight) SpawnTile(wallTileObj_C1, wallParent.transform, x, y);
                                else if (!floorTopLeft && !floorTopRight && floorBottomLeft && !floorBottomRight) SpawnTileRotated(wallTileObj_C1, wallParent.transform, -90f, x, y);
                                else if (!floorTopLeft && !floorTopRight && !floorBottomLeft && floorBottomRight) SpawnTileRotated(wallTileObj_C1, wallParent.transform, 180f, x, y);
                                else if (!floorTopLeft && floorTopRight && !floorBottomLeft && !floorBottomRight) SpawnTileRotated(wallTileObj_C1, wallParent.transform, 90f, x, y);

                                //2 sides
                                else if (floorTopLeft && floorTopRight && !floorBottomLeft && !floorBottomRight) SpawnTile(wallTileObj_C5, wallParent.transform, x, y);
                                else if (floorTopLeft && !floorTopRight && floorBottomLeft && !floorBottomRight) SpawnTileRotated(wallTileObj_C5, wallParent.transform, -90f, x, y);
                                else if (!floorTopLeft && !floorTopRight && floorBottomLeft && floorBottomRight) SpawnTileRotated(wallTileObj_C5, wallParent.transform, 180f, x, y);
                                else if (!floorTopLeft && floorTopRight && !floorBottomLeft && floorBottomRight) SpawnTileRotated(wallTileObj_C5, wallParent.transform, 90f, x, y);
                                else if (!floorTopLeft && floorTopRight && floorBottomLeft && !floorBottomRight) SpawnTile(wallTileObj_C9, wallParent.transform, x, y);
                                else if (floorTopLeft && !floorTopRight && !floorBottomLeft && floorBottomRight) SpawnTileRotated(wallTileObj_C9, wallParent.transform, -90f, x, y);

                                //3 sides
                                else if (floorTopLeft && floorTopRight && floorBottomLeft && !floorBottomRight) SpawnTile(wallTileObj_C11, wallParent.transform, x, y);
                                else if (floorTopLeft && !floorTopRight && floorBottomLeft && floorBottomRight) SpawnTileRotated(wallTileObj_C11, wallParent.transform, -90f, x, y);
                                else if (!floorTopLeft && floorTopRight && floorBottomLeft && floorBottomRight) SpawnTileRotated(wallTileObj_C11, wallParent.transform, 180f, x, y);
                                else if (floorTopLeft && floorTopRight && !floorBottomLeft && floorBottomRight) SpawnTileRotated(wallTileObj_C11, wallParent.transform, 90f, x, y);
                                else if (floorTopLeft && floorTopRight && floorBottomLeft && floorBottomRight) SpawnTile(wallTileObj_C31, wallParent.transform, x, y);
                                else SpawnTile(wallTileObj_1, wallParent.transform, x, y);
                            }
                            else SpawnTile(wallTileObj_1, wallParent.transform, x, y);
                        }
                        else if (drawEmptyTiles) SpawnTile(emptyTileObj, emptyParent.transform, x, y);
                    }

                    else if (drawEmptyTiles) SpawnTile(emptyTileObj, emptyParent.transform, x, y);
                }
            }
        }


        private void SpawnTiles()
        {
            for (int x = 0; x < levelSize.x; x++)
            {
                for (int y = 0; y < levelSize.y; y++)
                {
                    if (tiles[x, y] == tileType.floor && (!deleteFloorBelowOverlay || (deleteFloorBelowOverlay && overlayTiles[x, y] != overlayType.floorPattern && overlayTiles[x, y] != overlayType.floorRandom))) SpawnTile(floorTileObj_1, floorParent.transform, x, y);
                    else if (tiles[x, y] == tileType.wall) SpawnTile(wallTileObj_1, wallParent.transform, x, y);
                    else if (drawEmptyTiles) SpawnTile(emptyTileObj, emptyParent.transform, x, y);

                    if (overlayTiles[x, y] == overlayType.floorPattern) SpawnTile(patternFloorTileObj, overlayParent.transform, x, y);
                    else if (overlayTiles[x, y] == overlayType.floorRandom) SpawnTile(randomFloorTileObj, overlayParent.transform, x, y);
                    else if (overlayTiles[x, y] == overlayType.wallPattern) SpawnTile(patternWallTileObj_1, overlayParent.transform, x, y);
                    else if (overlayTiles[x, y] == overlayType.wallRandom) SpawnTile(randomWallTileObj_1, overlayParent.transform, x, y);
                }
            }
        }


        private void GenerateFloorCollider()
        {
            BoxCollider levelFloorCollider = floorParent.AddComponent<BoxCollider>();

            levelFloorCollider.center = new Vector3((int)levelSize.x / 2 * tileSize, 0f, (int)levelSize.y / 2 * tileSize);
            levelFloorCollider.size = new Vector3(levelSize.x * tileSize, levelColliderHeight, levelSize.y * tileSize);
        }


        private void GenerateWallTileCollider()
        {
            wallParent.AddComponent<Rigidbody2D>();
            wallParent.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

            wallParent.AddComponent<TilemapCollider2D>();

            wallParent.AddComponent<CompositeCollider2D>();
            wallParent.GetComponent<TilemapCollider2D>().usedByComposite = true;
        }


        private void GenerateWallCompositeCollider2D()
        {
            wallParent.AddComponent<Rigidbody2D>();
            wallParent.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

            wallParent.AddComponent<CompositeCollider2D>();
        }


        private void RotateLevel()
        {
            if (levelRot == levelRotation.XY) this.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
            else if (levelRot == levelRotation.ZY) this.transform.rotation = Quaternion.Euler(-90f, 0f, -90f);
            else this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        #endregion


        #region Utils

        private void SpawnTileRotated(GameObject _tileObj, Transform _parentTrm, float _rotation, int _posX, int _posY)
        {
            if(_tileObj != null)
            {
                GameObject instObj = GameObject.Instantiate(_tileObj, new Vector3(_posX * tileSize, 0, _posY * tileSize), _tileObj.transform.rotation * Quaternion.Euler(0f, _rotation, 0f));
                instObj.transform.parent = _parentTrm;
                instObj.transform.localPosition = new Vector3(instObj.transform.position.x, 0f, instObj.transform.position.z);
            }
        }


        private void SpawnTile(GameObject _tileObj, Transform _parentTrm, int _posX, int _posY)
        {
            if (_tileObj != null)
            {
                GameObject instObj = GameObject.Instantiate(_tileObj, new Vector3(_posX * tileSize, 0, _posY * tileSize), Quaternion.identity);
                instObj.transform.parent = _parentTrm;
                instObj.transform.localPosition = new Vector3(instObj.transform.position.x, 0f, instObj.transform.position.z);
            }
        }


        private int TileTypeNumber(tileType _tileType)
        {
            int count = 0;
            foreach (tileType tile in tiles) if (tile == _tileType) count++;

            return count;
        }


        private bool IsFloorTouchingWall(int _posX, int _posY)
        {
            return (tiles[_posX, _posY] == tileType.floor && tiles[_posX + 1, _posY] != tileType.wall && tiles[_posX + 1, _posY + 1] != tileType.wall && tiles[_posX, _posY + 1] != tileType.wall && tiles[_posX - 1, _posY + 1] != tileType.wall && tiles[_posX - 1, _posY] != tileType.wall && tiles[_posX - 1, _posY - 1] != tileType.wall && tiles[_posX, _posY - 1] != tileType.wall && tiles[_posX + 1, _posY - 1] != tileType.wall);
        }

        #endregion


        #region Getters

        public tileType[,] GetTiles()
        {
            return tiles;
        }


        public overlayType[,] GetOverlayTiles()
        {
            return overlayTiles;
        }


        public Vector2Int GetLevelSize()
        {
            return levelSize;
        }


        public float GetTilesSize()
        {
            return tileSize;
        }


        public levelRotation GetLevelRotation()
        {
            return levelRot;
        }


        public genType GetGenerationType()
        {
            return generation;
        }

        #endregion
    }
}