using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;
using static RoguelikeGeneratorPro.RoguelikeGeneratorPro;


namespace RoguelikeGeneratorPro
{
    public static class BackgroundStyle
    {
        private static GUIStyle style = new GUIStyle();
        private static Texture2D texture = new Texture2D(1, 1);


        public static GUIStyle Get(Color color)
        {
            if (texture == null) texture = new Texture2D(1, 1);
            if (style == null) style = new GUIStyle();

            texture.SetPixel(0, 0, color);
            texture.Apply();

            style.normal.background = texture;
            return style;
        }
    }


    [CustomEditor(typeof(RoguelikeGeneratorPro))]
    public class RoguelikeGeneratorProEditor : Editor
    {
        #region EditorSpecificVars

        public Texture empty_txt;
        public Texture overlayPatternFloor_txt;
        public Texture overlayRandomFloor_txt;

        public Texture floorTileObj_1_txt;
        public Texture floorTileObj_2_txt;
        public Texture floorTileObj_3_txt;
        public Texture floorTileObj_4_txt;
        public Texture floorTileObj_5_txt;
        public Texture floorTileObj_6_txt;
        public Texture floorTileObj_7_txt;
        public Texture floorTileObj_8_txt;
        public Texture floorTileObj_9_txt;
        public Texture floorTileObj_10_txt;
        public Texture floorTileObj_11_txt;
        public Texture floorTileObj_12_txt;
        public Texture floorTileObj_13_txt;
        public Texture floorTileObj_14_txt;
        public Texture floorTileObj_15_txt;

        public Texture floorTileObj_C1_txt;
        public Texture floorTileObj_C2_txt;
        public Texture floorTileObj_C3_txt;
        public Texture floorTileObj_C4_txt;
        public Texture floorTileObj_C5_txt;
        public Texture floorTileObj_C6_txt;
        public Texture floorTileObj_C7_txt;
        public Texture floorTileObj_C8_txt;
        public Texture floorTileObj_C9_txt;
        public Texture floorTileObj_C10_txt;
        public Texture floorTileObj_C11_txt;
        public Texture floorTileObj_C12_txt;
        public Texture floorTileObj_C13_txt;
        public Texture floorTileObj_C14_txt;
        public Texture floorTileObj_C15_txt;
        public Texture floorTileObj_C16_txt;
        public Texture floorTileObj_C17_txt;
        public Texture floorTileObj_C18_txt;
        public Texture floorTileObj_C19_txt;
        public Texture floorTileObj_C20_txt;
        public Texture floorTileObj_C21_txt;
        public Texture floorTileObj_C22_txt;
        public Texture floorTileObj_C23_txt;
        public Texture floorTileObj_C24_txt;
        public Texture floorTileObj_C25_txt;
        public Texture floorTileObj_C26_txt;
        public Texture floorTileObj_C27_txt;
        public Texture floorTileObj_C28_txt;
        public Texture floorTileObj_C29_txt;
        public Texture floorTileObj_C30_txt;
        public Texture floorTileObj_C31_txt;

        public Texture wallTileObj_1_txt;
        public Texture wallTileObj_2_txt;
        public Texture wallTileObj_3_txt;
        public Texture wallTileObj_4_txt;
        public Texture wallTileObj_5_txt;
        public Texture wallTileObj_6_txt;
        public Texture wallTileObj_7_txt;
        public Texture wallTileObj_8_txt;
        public Texture wallTileObj_9_txt;
        public Texture wallTileObj_10_txt;
        public Texture wallTileObj_11_txt;
        public Texture wallTileObj_12_txt;
        public Texture wallTileObj_13_txt;
        public Texture wallTileObj_14_txt;
        public Texture wallTileObj_15_txt;

        public Texture wallTileObj_C1_txt;
        public Texture wallTileObj_C2_txt;
        public Texture wallTileObj_C3_txt;
        public Texture wallTileObj_C4_txt;
        public Texture wallTileObj_C5_txt;
        public Texture wallTileObj_C6_txt;
        public Texture wallTileObj_C7_txt;
        public Texture wallTileObj_C8_txt;
        public Texture wallTileObj_C9_txt;
        public Texture wallTileObj_C10_txt;
        public Texture wallTileObj_C11_txt;
        public Texture wallTileObj_C12_txt;
        public Texture wallTileObj_C13_txt;
        public Texture wallTileObj_C14_txt;
        public Texture wallTileObj_C15_txt;
        public Texture wallTileObj_C16_txt;
        public Texture wallTileObj_C17_txt;
        public Texture wallTileObj_C18_txt;
        public Texture wallTileObj_C19_txt;
        public Texture wallTileObj_C20_txt;
        public Texture wallTileObj_C21_txt;
        public Texture wallTileObj_C22_txt;
        public Texture wallTileObj_C23_txt;
        public Texture wallTileObj_C24_txt;
        public Texture wallTileObj_C25_txt;
        public Texture wallTileObj_C26_txt;
        public Texture wallTileObj_C27_txt;
        public Texture wallTileObj_C28_txt;
        public Texture wallTileObj_C29_txt;
        public Texture wallTileObj_C30_txt;
        public Texture wallTileObj_C31_txt;

        public Texture wallTilePatternObj_1_txt;
        public Texture wallTilePatternObj_2_txt;
        public Texture wallTilePatternObj_3_txt;
        public Texture wallTilePatternObj_4_txt;
        public Texture wallTilePatternObj_5_txt;
        public Texture wallTilePatternObj_6_txt;
        public Texture wallTilePatternObj_7_txt;
        public Texture wallTilePatternObj_8_txt;
        public Texture wallTilePatternObj_9_txt;
        public Texture wallTilePatternObj_10_txt;
        public Texture wallTilePatternObj_11_txt;
        public Texture wallTilePatternObj_12_txt;
        public Texture wallTilePatternObj_13_txt;
        public Texture wallTilePatternObj_14_txt;
        public Texture wallTilePatternObj_15_txt;

        public Texture wallTileRandomObj_1_txt;
        public Texture wallTileRandomObj_2_txt;
        public Texture wallTileRandomObj_3_txt;
        public Texture wallTileRandomObj_4_txt;
        public Texture wallTileRandomObj_5_txt;
        public Texture wallTileRandomObj_6_txt;
        public Texture wallTileRandomObj_7_txt;
        public Texture wallTileRandomObj_8_txt;
        public Texture wallTileRandomObj_9_txt;
        public Texture wallTileRandomObj_10_txt;
        public Texture wallTileRandomObj_11_txt;
        public Texture wallTileRandomObj_12_txt;
        public Texture wallTileRandomObj_13_txt;
        public Texture wallTileRandomObj_14_txt;
        public Texture wallTileRandomObj_15_txt;

        private GUIStyle alignGUILeft;
        private GUIStyle alignGUIRight;

        #endregion


        #region SerializedVars

        //Level dimensions
        private SerializedProperty _levelSize;
        private SerializedProperty _tileSize;
        private SerializedProperty _percentLevelToFill;
        private SerializedProperty _spawnCornerWalls;
        private SerializedProperty _removeUnnaturalWalls;
        private SerializedProperty _useSeed;
        private SerializedProperty _generationSeed;


        //PathMaker properties
        private SerializedProperty _pathMakerDestructionChance;
        private SerializedProperty _pathMakerSpawnChance;
        private SerializedProperty _pathMakerRotationChance;
        private SerializedProperty _pathMakerRotatesLeft;
        private SerializedProperty _pathMakerRotatesRight;
        private SerializedProperty _pathMakerRotatesBackwords;
        private SerializedProperty _pathMakerMaxDensity;


        //Chunk properties
        private SerializedProperty _chunkSpawnChance;
        private SerializedProperty _chunkChance2x2;
        private SerializedProperty _chunkChance3x3;


        //Pattern floor overlay
        private SerializedProperty _patternFloor;
        private SerializedProperty _noiseScaleFloor;
        private SerializedProperty _noiseCutoffFloor;

        //Pattern wall overlay
        private SerializedProperty _patternWall;
        private SerializedProperty _noiseScaleWall;
        private SerializedProperty _noiseCutoffWall;


        //Random floor overlay
        private SerializedProperty _randomFloorOverlayChance;


        //Random wall overlay
        private SerializedProperty _randomWallOverlayChance;


        //TilesObj generation references
        private SerializedProperty _tabSelected;
        private SerializedProperty _generation;
        private SerializedProperty _fillAllTiles;
        private SerializedProperty _drawCorners;

        private SerializedProperty _drawEmptyTiles;
        private SerializedProperty _emptyTileObj;

        private SerializedProperty _drawFloorOverlayPatternTiles;
        private SerializedProperty _patternFloorTileObj;

        private SerializedProperty _drawFloorOverlayRandomTiles;
        private SerializedProperty _randomFloorTileObj;

        private SerializedProperty _drawTilesOrientation;
        private SerializedProperty _floorTileObj_1;
        private SerializedProperty _floorTileObj_2;
        private SerializedProperty _floorTileObj_3;
        private SerializedProperty _floorTileObj_4;
        private SerializedProperty _floorTileObj_5;
        private SerializedProperty _floorTileObj_6;
        private SerializedProperty _floorTileObj_7;
        private SerializedProperty _floorTileObj_8;
        private SerializedProperty _floorTileObj_9;
        private SerializedProperty _floorTileObj_10;
        private SerializedProperty _floorTileObj_11;
        private SerializedProperty _floorTileObj_12;
        private SerializedProperty _floorTileObj_13;
        private SerializedProperty _floorTileObj_14;
        private SerializedProperty _floorTileObj_15;

        private SerializedProperty _floorTileObj_C1;
        private SerializedProperty _floorTileObj_C2;
        private SerializedProperty _floorTileObj_C3;
        private SerializedProperty _floorTileObj_C4;
        private SerializedProperty _floorTileObj_C5;
        private SerializedProperty _floorTileObj_C6;
        private SerializedProperty _floorTileObj_C7;
        private SerializedProperty _floorTileObj_C8;
        private SerializedProperty _floorTileObj_C9;
        private SerializedProperty _floorTileObj_C10;
        private SerializedProperty _floorTileObj_C11;
        private SerializedProperty _floorTileObj_C12;
        private SerializedProperty _floorTileObj_C13;
        private SerializedProperty _floorTileObj_C14;
        private SerializedProperty _floorTileObj_C15;
        private SerializedProperty _floorTileObj_C16;
        private SerializedProperty _floorTileObj_C17;
        private SerializedProperty _floorTileObj_C18;
        private SerializedProperty _floorTileObj_C19;
        private SerializedProperty _floorTileObj_C20;
        private SerializedProperty _floorTileObj_C21;
        private SerializedProperty _floorTileObj_C22;
        private SerializedProperty _floorTileObj_C23;
        private SerializedProperty _floorTileObj_C24;
        private SerializedProperty _floorTileObj_C25;
        private SerializedProperty _floorTileObj_C26;
        private SerializedProperty _floorTileObj_C27;
        private SerializedProperty _floorTileObj_C28;
        private SerializedProperty _floorTileObj_C29;
        private SerializedProperty _floorTileObj_C30;
        private SerializedProperty _floorTileObj_C31;

        private SerializedProperty _wallTileObj_1;
        private SerializedProperty _wallTileObj_2;
        private SerializedProperty _wallTileObj_3;
        private SerializedProperty _wallTileObj_4;
        private SerializedProperty _wallTileObj_5;
        private SerializedProperty _wallTileObj_6;
        private SerializedProperty _wallTileObj_7;
        private SerializedProperty _wallTileObj_8;
        private SerializedProperty _wallTileObj_9;
        private SerializedProperty _wallTileObj_10;
        private SerializedProperty _wallTileObj_11;
        private SerializedProperty _wallTileObj_12;
        private SerializedProperty _wallTileObj_13;
        private SerializedProperty _wallTileObj_14;
        private SerializedProperty _wallTileObj_15;

        private SerializedProperty _wallTileObj_C1;
        private SerializedProperty _wallTileObj_C2;
        private SerializedProperty _wallTileObj_C3;
        private SerializedProperty _wallTileObj_C4;
        private SerializedProperty _wallTileObj_C5;
        private SerializedProperty _wallTileObj_C6;
        private SerializedProperty _wallTileObj_C7;
        private SerializedProperty _wallTileObj_C8;
        private SerializedProperty _wallTileObj_C9;
        private SerializedProperty _wallTileObj_C10;
        private SerializedProperty _wallTileObj_C11;
        private SerializedProperty _wallTileObj_C12;
        private SerializedProperty _wallTileObj_C13;
        private SerializedProperty _wallTileObj_C14;
        private SerializedProperty _wallTileObj_C15;
        private SerializedProperty _wallTileObj_C16;
        private SerializedProperty _wallTileObj_C17;
        private SerializedProperty _wallTileObj_C18;
        private SerializedProperty _wallTileObj_C19;
        private SerializedProperty _wallTileObj_C20;
        private SerializedProperty _wallTileObj_C21;
        private SerializedProperty _wallTileObj_C22;
        private SerializedProperty _wallTileObj_C23;
        private SerializedProperty _wallTileObj_C24;
        private SerializedProperty _wallTileObj_C25;
        private SerializedProperty _wallTileObj_C26;
        private SerializedProperty _wallTileObj_C27;
        private SerializedProperty _wallTileObj_C28;
        private SerializedProperty _wallTileObj_C29;
        private SerializedProperty _wallTileObj_C30;
        private SerializedProperty _wallTileObj_C31;

        private SerializedProperty _drawWallOverlayPatternTiles;
        private SerializedProperty _patternWallTileObj_1;
        private SerializedProperty _patternWallTileObj_2;
        private SerializedProperty _patternWallTileObj_3;
        private SerializedProperty _patternWallTileObj_4;
        private SerializedProperty _patternWallTileObj_5;
        private SerializedProperty _patternWallTileObj_6;
        private SerializedProperty _patternWallTileObj_7;
        private SerializedProperty _patternWallTileObj_8;
        private SerializedProperty _patternWallTileObj_9;
        private SerializedProperty _patternWallTileObj_10;
        private SerializedProperty _patternWallTileObj_11;
        private SerializedProperty _patternWallTileObj_12;
        private SerializedProperty _patternWallTileObj_13;
        private SerializedProperty _patternWallTileObj_14;
        private SerializedProperty _patternWallTileObj_15;

        private SerializedProperty _drawWallOverlayRandomTiles;
        private SerializedProperty _randomWallTileObj_1;
        private SerializedProperty _randomWallTileObj_2;
        private SerializedProperty _randomWallTileObj_3;
        private SerializedProperty _randomWallTileObj_4;
        private SerializedProperty _randomWallTileObj_5;
        private SerializedProperty _randomWallTileObj_6;
        private SerializedProperty _randomWallTileObj_7;
        private SerializedProperty _randomWallTileObj_8;
        private SerializedProperty _randomWallTileObj_9;
        private SerializedProperty _randomWallTileObj_10;
        private SerializedProperty _randomWallTileObj_11;
        private SerializedProperty _randomWallTileObj_12;
        private SerializedProperty _randomWallTileObj_13;
        private SerializedProperty _randomWallTileObj_14;
        private SerializedProperty _randomWallTileObj_15;


        //Tiles generation references
        private SerializedProperty _emptyTile;
        private SerializedProperty _patternFloorTile;
        private SerializedProperty _randomFloorTile;

        private SerializedProperty _floorTile_1;
        private SerializedProperty _floorTile_2;
        private SerializedProperty _floorTile_3;
        private SerializedProperty _floorTile_4;
        private SerializedProperty _floorTile_5;
        private SerializedProperty _floorTile_6;
        private SerializedProperty _floorTile_7;
        private SerializedProperty _floorTile_8;
        private SerializedProperty _floorTile_9;
        private SerializedProperty _floorTile_10;
        private SerializedProperty _floorTile_11;
        private SerializedProperty _floorTile_12;
        private SerializedProperty _floorTile_13;
        private SerializedProperty _floorTile_14;
        private SerializedProperty _floorTile_15;

        private SerializedProperty _floorTile_C1;
        private SerializedProperty _floorTile_C2;
        private SerializedProperty _floorTile_C3;
        private SerializedProperty _floorTile_C4;
        private SerializedProperty _floorTile_C5;
        private SerializedProperty _floorTile_C6;
        private SerializedProperty _floorTile_C7;
        private SerializedProperty _floorTile_C8;
        private SerializedProperty _floorTile_C9;
        private SerializedProperty _floorTile_C10;
        private SerializedProperty _floorTile_C11;
        private SerializedProperty _floorTile_C12;
        private SerializedProperty _floorTile_C13;
        private SerializedProperty _floorTile_C14;
        private SerializedProperty _floorTile_C15;
        private SerializedProperty _floorTile_C16;
        private SerializedProperty _floorTile_C17;
        private SerializedProperty _floorTile_C18;
        private SerializedProperty _floorTile_C19;
        private SerializedProperty _floorTile_C20;
        private SerializedProperty _floorTile_C21;
        private SerializedProperty _floorTile_C22;
        private SerializedProperty _floorTile_C23;
        private SerializedProperty _floorTile_C24;
        private SerializedProperty _floorTile_C25;
        private SerializedProperty _floorTile_C26;
        private SerializedProperty _floorTile_C27;
        private SerializedProperty _floorTile_C28;
        private SerializedProperty _floorTile_C29;
        private SerializedProperty _floorTile_C30;
        private SerializedProperty _floorTile_C31;

        private SerializedProperty _wallTile_1;
        private SerializedProperty _wallTile_2;
        private SerializedProperty _wallTile_3;
        private SerializedProperty _wallTile_4;
        private SerializedProperty _wallTile_5;
        private SerializedProperty _wallTile_6;
        private SerializedProperty _wallTile_7;
        private SerializedProperty _wallTile_8;
        private SerializedProperty _wallTile_9;
        private SerializedProperty _wallTile_10;
        private SerializedProperty _wallTile_11;
        private SerializedProperty _wallTile_12;
        private SerializedProperty _wallTile_13;
        private SerializedProperty _wallTile_14;
        private SerializedProperty _wallTile_15;

        private SerializedProperty _wallTile_C1;
        private SerializedProperty _wallTile_C2;
        private SerializedProperty _wallTile_C3;
        private SerializedProperty _wallTile_C4;
        private SerializedProperty _wallTile_C5;
        private SerializedProperty _wallTile_C6;
        private SerializedProperty _wallTile_C7;
        private SerializedProperty _wallTile_C8;
        private SerializedProperty _wallTile_C9;
        private SerializedProperty _wallTile_C10;
        private SerializedProperty _wallTile_C11;
        private SerializedProperty _wallTile_C12;
        private SerializedProperty _wallTile_C13;
        private SerializedProperty _wallTile_C14;
        private SerializedProperty _wallTile_C15;
        private SerializedProperty _wallTile_C16;
        private SerializedProperty _wallTile_C17;
        private SerializedProperty _wallTile_C18;
        private SerializedProperty _wallTile_C19;
        private SerializedProperty _wallTile_C20;
        private SerializedProperty _wallTile_C21;
        private SerializedProperty _wallTile_C22;
        private SerializedProperty _wallTile_C23;
        private SerializedProperty _wallTile_C24;
        private SerializedProperty _wallTile_C25;
        private SerializedProperty _wallTile_C26;
        private SerializedProperty _wallTile_C27;
        private SerializedProperty _wallTile_C28;
        private SerializedProperty _wallTile_C29;
        private SerializedProperty _wallTile_C30;
        private SerializedProperty _wallTile_C31;

        private SerializedProperty _patternWallTile_1;
        private SerializedProperty _patternWallTile_2;
        private SerializedProperty _patternWallTile_3;
        private SerializedProperty _patternWallTile_4;
        private SerializedProperty _patternWallTile_5;
        private SerializedProperty _patternWallTile_6;
        private SerializedProperty _patternWallTile_7;
        private SerializedProperty _patternWallTile_8;
        private SerializedProperty _patternWallTile_9;
        private SerializedProperty _patternWallTile_10;
        private SerializedProperty _patternWallTile_11;
        private SerializedProperty _patternWallTile_12;
        private SerializedProperty _patternWallTile_13;
        private SerializedProperty _patternWallTile_14;
        private SerializedProperty _patternWallTile_15;

        private SerializedProperty _randomWallTile_1;
        private SerializedProperty _randomWallTile_2;
        private SerializedProperty _randomWallTile_3;
        private SerializedProperty _randomWallTile_4;
        private SerializedProperty _randomWallTile_5;
        private SerializedProperty _randomWallTile_6;
        private SerializedProperty _randomWallTile_7;
        private SerializedProperty _randomWallTile_8;
        private SerializedProperty _randomWallTile_9;
        private SerializedProperty _randomWallTile_10;
        private SerializedProperty _randomWallTile_11;
        private SerializedProperty _randomWallTile_12;
        private SerializedProperty _randomWallTile_13;
        private SerializedProperty _randomWallTile_14;
        private SerializedProperty _randomWallTile_15;


        //Level floor collider
        private SerializedProperty _createLevelSizedFloorCollider;
        private SerializedProperty _createWallCompositeCollider;
        private SerializedProperty _deleteFloorBelowOverlay;
        private SerializedProperty _createWallGridCollider;
        private SerializedProperty _levelColliderHeight;
        private SerializedProperty _rotateLevel;


        //Offset
        private SerializedProperty _floorOffset;
        private SerializedProperty _wallOffset;
        private SerializedProperty _overlayOffset;
        private SerializedProperty _emptyOffset;

        #endregion


        private string[] tabs = { "Generate GameObjects", "Generate Grid", "No Generation" };
        private RoguelikeGeneratorPro script;


        /**/


        private void OnEnable()
        {
            //Level dimensions
            _levelSize = serializedObject.FindProperty("levelSize");
            _tileSize = serializedObject.FindProperty("tileSize");
            _percentLevelToFill = serializedObject.FindProperty("percentLevelToFill");
            _spawnCornerWalls = serializedObject.FindProperty("spawnCornerWalls");
            _removeUnnaturalWalls = serializedObject.FindProperty("removeUnnaturalWalls");
            _useSeed = serializedObject.FindProperty("useSeed");
            _generationSeed = serializedObject.FindProperty("generationSeed");


            //PathMaker properties
            _pathMakerDestructionChance = serializedObject.FindProperty("pathMakerDestructionChance");
            _pathMakerSpawnChance = serializedObject.FindProperty("pathMakerSpawnChance");
            _pathMakerRotationChance = serializedObject.FindProperty("pathMakerRotationChance");
            _pathMakerRotatesLeft = serializedObject.FindProperty("pathMakerRotatesLeft");
            _pathMakerRotatesRight = serializedObject.FindProperty("pathMakerRotatesRight");
            _pathMakerRotatesBackwords = serializedObject.FindProperty("pathMakerRotatesBackwords");
            _pathMakerMaxDensity = serializedObject.FindProperty("pathMakerMaxDensity");


            //Chunk properties
            _chunkSpawnChance = serializedObject.FindProperty("chunkSpawnChance");
            _chunkChance2x2 = serializedObject.FindProperty("chunkChance2x2");
            _chunkChance3x3 = serializedObject.FindProperty("chunkChance3x3");


            //Pattern floor overlay
            _patternFloor = serializedObject.FindProperty("patternFloor");
            _noiseScaleFloor = serializedObject.FindProperty("noiseScaleFloor");
            _noiseCutoffFloor = serializedObject.FindProperty("noiseCutoffFloor");


            //Pattern wall overlay
            _patternWall = serializedObject.FindProperty("patternWall");
            _noiseScaleWall = serializedObject.FindProperty("noiseScaleWall");
            _noiseCutoffWall = serializedObject.FindProperty("noiseCutoffWall");


            //Random floor overlay
            _randomFloorOverlayChance = serializedObject.FindProperty("randomFloorOverlayChance");


            //Random wall overlay
            _randomWallOverlayChance = serializedObject.FindProperty("randomWallOverlayChance");


            //TilesObj generation references
            _tabSelected = serializedObject.FindProperty("tabSelected");
            _generation = serializedObject.FindProperty("generation");
            _fillAllTiles = serializedObject.FindProperty("fillAllTiles");
            _drawCorners = serializedObject.FindProperty("drawCorners");

            _drawEmptyTiles = serializedObject.FindProperty("drawEmptyTiles");
            _emptyTileObj = serializedObject.FindProperty("emptyTileObj");

            _drawFloorOverlayPatternTiles = serializedObject.FindProperty("drawFloorOverlayPatternTiles");
            _patternFloorTileObj = serializedObject.FindProperty("patternFloorTileObj");

            _drawFloorOverlayRandomTiles = serializedObject.FindProperty("drawFloorOverlayRandomTiles");
            _randomFloorTileObj = serializedObject.FindProperty("randomFloorTileObj");

            _drawTilesOrientation = serializedObject.FindProperty("drawTilesOrientation");
            _floorTileObj_1 = serializedObject.FindProperty("floorTileObj_1");
            _floorTileObj_2 = serializedObject.FindProperty("floorTileObj_2");
            _floorTileObj_3 = serializedObject.FindProperty("floorTileObj_3");
            _floorTileObj_4 = serializedObject.FindProperty("floorTileObj_4");
            _floorTileObj_5 = serializedObject.FindProperty("floorTileObj_5");
            _floorTileObj_6 = serializedObject.FindProperty("floorTileObj_6");
            _floorTileObj_7 = serializedObject.FindProperty("floorTileObj_7");
            _floorTileObj_8 = serializedObject.FindProperty("floorTileObj_8");
            _floorTileObj_9 = serializedObject.FindProperty("floorTileObj_9");
            _floorTileObj_10 = serializedObject.FindProperty("floorTileObj_10");
            _floorTileObj_11 = serializedObject.FindProperty("floorTileObj_11");
            _floorTileObj_12 = serializedObject.FindProperty("floorTileObj_12");
            _floorTileObj_13 = serializedObject.FindProperty("floorTileObj_13");
            _floorTileObj_14 = serializedObject.FindProperty("floorTileObj_14");
            _floorTileObj_15 = serializedObject.FindProperty("floorTileObj_15");

            _floorTileObj_C1 = serializedObject.FindProperty("floorTileObj_C1");
            _floorTileObj_C2 = serializedObject.FindProperty("floorTileObj_C2");
            _floorTileObj_C3 = serializedObject.FindProperty("floorTileObj_C3");
            _floorTileObj_C4 = serializedObject.FindProperty("floorTileObj_C4");
            _floorTileObj_C5 = serializedObject.FindProperty("floorTileObj_C5");
            _floorTileObj_C6 = serializedObject.FindProperty("floorTileObj_C6");
            _floorTileObj_C7 = serializedObject.FindProperty("floorTileObj_C7");
            _floorTileObj_C8 = serializedObject.FindProperty("floorTileObj_C8");
            _floorTileObj_C9 = serializedObject.FindProperty("floorTileObj_C9");
            _floorTileObj_C10 = serializedObject.FindProperty("floorTileObj_C10");
            _floorTileObj_C11 = serializedObject.FindProperty("floorTileObj_C11");
            _floorTileObj_C12 = serializedObject.FindProperty("floorTileObj_C12");
            _floorTileObj_C13 = serializedObject.FindProperty("floorTileObj_C13");
            _floorTileObj_C14 = serializedObject.FindProperty("floorTileObj_C14");
            _floorTileObj_C15 = serializedObject.FindProperty("floorTileObj_C15");
            _floorTileObj_C16 = serializedObject.FindProperty("floorTileObj_C16");
            _floorTileObj_C17 = serializedObject.FindProperty("floorTileObj_C17");
            _floorTileObj_C18 = serializedObject.FindProperty("floorTileObj_C18");
            _floorTileObj_C19 = serializedObject.FindProperty("floorTileObj_C19");
            _floorTileObj_C20 = serializedObject.FindProperty("floorTileObj_C20");
            _floorTileObj_C21 = serializedObject.FindProperty("floorTileObj_C21");
            _floorTileObj_C22 = serializedObject.FindProperty("floorTileObj_C22");
            _floorTileObj_C23 = serializedObject.FindProperty("floorTileObj_C23");
            _floorTileObj_C24 = serializedObject.FindProperty("floorTileObj_C24");
            _floorTileObj_C25 = serializedObject.FindProperty("floorTileObj_C25");
            _floorTileObj_C26 = serializedObject.FindProperty("floorTileObj_C26");
            _floorTileObj_C27 = serializedObject.FindProperty("floorTileObj_C27");
            _floorTileObj_C28 = serializedObject.FindProperty("floorTileObj_C28");
            _floorTileObj_C29 = serializedObject.FindProperty("floorTileObj_C29");
            _floorTileObj_C30 = serializedObject.FindProperty("floorTileObj_C30");
            _floorTileObj_C31 = serializedObject.FindProperty("floorTileObj_C31");

            _wallTileObj_1 = serializedObject.FindProperty("wallTileObj_1");
            _wallTileObj_2 = serializedObject.FindProperty("wallTileObj_2");
            _wallTileObj_3 = serializedObject.FindProperty("wallTileObj_3");
            _wallTileObj_4 = serializedObject.FindProperty("wallTileObj_4");
            _wallTileObj_5 = serializedObject.FindProperty("wallTileObj_5");
            _wallTileObj_6 = serializedObject.FindProperty("wallTileObj_6");
            _wallTileObj_7 = serializedObject.FindProperty("wallTileObj_7");
            _wallTileObj_8 = serializedObject.FindProperty("wallTileObj_8");
            _wallTileObj_9 = serializedObject.FindProperty("wallTileObj_9");
            _wallTileObj_10 = serializedObject.FindProperty("wallTileObj_10");
            _wallTileObj_11 = serializedObject.FindProperty("wallTileObj_11");
            _wallTileObj_12 = serializedObject.FindProperty("wallTileObj_12");
            _wallTileObj_13 = serializedObject.FindProperty("wallTileObj_13");
            _wallTileObj_14 = serializedObject.FindProperty("wallTileObj_14");
            _wallTileObj_15 = serializedObject.FindProperty("wallTileObj_15");

            _wallTileObj_C1 = serializedObject.FindProperty("wallTileObj_C1");
            _wallTileObj_C2 = serializedObject.FindProperty("wallTileObj_C2");
            _wallTileObj_C3 = serializedObject.FindProperty("wallTileObj_C3");
            _wallTileObj_C4 = serializedObject.FindProperty("wallTileObj_C4");
            _wallTileObj_C5 = serializedObject.FindProperty("wallTileObj_C5");
            _wallTileObj_C6 = serializedObject.FindProperty("wallTileObj_C6");
            _wallTileObj_C7 = serializedObject.FindProperty("wallTileObj_C7");
            _wallTileObj_C8 = serializedObject.FindProperty("wallTileObj_C8");
            _wallTileObj_C9 = serializedObject.FindProperty("wallTileObj_C9");
            _wallTileObj_C10 = serializedObject.FindProperty("wallTileObj_C10");
            _wallTileObj_C11 = serializedObject.FindProperty("wallTileObj_C11");
            _wallTileObj_C12 = serializedObject.FindProperty("wallTileObj_C12");
            _wallTileObj_C13 = serializedObject.FindProperty("wallTileObj_C13");
            _wallTileObj_C14 = serializedObject.FindProperty("wallTileObj_C14");
            _wallTileObj_C15 = serializedObject.FindProperty("wallTileObj_C15");
            _wallTileObj_C16 = serializedObject.FindProperty("wallTileObj_C16");
            _wallTileObj_C17 = serializedObject.FindProperty("wallTileObj_C17");
            _wallTileObj_C18 = serializedObject.FindProperty("wallTileObj_C18");
            _wallTileObj_C19 = serializedObject.FindProperty("wallTileObj_C19");
            _wallTileObj_C20 = serializedObject.FindProperty("wallTileObj_C20");
            _wallTileObj_C21 = serializedObject.FindProperty("wallTileObj_C21");
            _wallTileObj_C22 = serializedObject.FindProperty("wallTileObj_C22");
            _wallTileObj_C23 = serializedObject.FindProperty("wallTileObj_C23");
            _wallTileObj_C24 = serializedObject.FindProperty("wallTileObj_C24");
            _wallTileObj_C25 = serializedObject.FindProperty("wallTileObj_C25");
            _wallTileObj_C26 = serializedObject.FindProperty("wallTileObj_C26");
            _wallTileObj_C27 = serializedObject.FindProperty("wallTileObj_C27");
            _wallTileObj_C28 = serializedObject.FindProperty("wallTileObj_C28");
            _wallTileObj_C29 = serializedObject.FindProperty("wallTileObj_C29");
            _wallTileObj_C30 = serializedObject.FindProperty("wallTileObj_C30");
            _wallTileObj_C31 = serializedObject.FindProperty("wallTileObj_C31");

            _drawWallOverlayPatternTiles = serializedObject.FindProperty("drawWallOverlayPatternTiles");
            _patternWallTileObj_1 = serializedObject.FindProperty("patternWallTileObj_1");
            _patternWallTileObj_2 = serializedObject.FindProperty("patternWallTileObj_2");
            _patternWallTileObj_3 = serializedObject.FindProperty("patternWallTileObj_3");
            _patternWallTileObj_4 = serializedObject.FindProperty("patternWallTileObj_4");
            _patternWallTileObj_5 = serializedObject.FindProperty("patternWallTileObj_5");
            _patternWallTileObj_6 = serializedObject.FindProperty("patternWallTileObj_6");
            _patternWallTileObj_7 = serializedObject.FindProperty("patternWallTileObj_7");
            _patternWallTileObj_8 = serializedObject.FindProperty("patternWallTileObj_8");
            _patternWallTileObj_9 = serializedObject.FindProperty("patternWallTileObj_9");
            _patternWallTileObj_10 = serializedObject.FindProperty("patternWallTileObj_10");
            _patternWallTileObj_11 = serializedObject.FindProperty("patternWallTileObj_11");
            _patternWallTileObj_12 = serializedObject.FindProperty("patternWallTileObj_12");
            _patternWallTileObj_13 = serializedObject.FindProperty("patternWallTileObj_13");
            _patternWallTileObj_14 = serializedObject.FindProperty("patternWallTileObj_14");
            _patternWallTileObj_15 = serializedObject.FindProperty("patternWallTileObj_15");

            _drawWallOverlayRandomTiles = serializedObject.FindProperty("drawWallOverlayRandomTiles");
            _randomWallTileObj_1 = serializedObject.FindProperty("randomWallTileObj_1");
            _randomWallTileObj_2 = serializedObject.FindProperty("randomWallTileObj_2");
            _randomWallTileObj_3 = serializedObject.FindProperty("randomWallTileObj_3");
            _randomWallTileObj_4 = serializedObject.FindProperty("randomWallTileObj_4");
            _randomWallTileObj_5 = serializedObject.FindProperty("randomWallTileObj_5");
            _randomWallTileObj_6 = serializedObject.FindProperty("randomWallTileObj_6");
            _randomWallTileObj_7 = serializedObject.FindProperty("randomWallTileObj_7");
            _randomWallTileObj_8 = serializedObject.FindProperty("randomWallTileObj_8");
            _randomWallTileObj_9 = serializedObject.FindProperty("randomWallTileObj_9");
            _randomWallTileObj_10 = serializedObject.FindProperty("randomWallTileObj_10");
            _randomWallTileObj_11 = serializedObject.FindProperty("randomWallTileObj_11");
            _randomWallTileObj_12 = serializedObject.FindProperty("randomWallTileObj_12");
            _randomWallTileObj_13 = serializedObject.FindProperty("randomWallTileObj_13");
            _randomWallTileObj_14 = serializedObject.FindProperty("randomWallTileObj_14");
            _randomWallTileObj_15 = serializedObject.FindProperty("randomWallTileObj_15");


            //Tiles generation references
            _emptyTile = serializedObject.FindProperty("emptyTile");
            _patternFloorTile = serializedObject.FindProperty("patternFloorTile");
            _randomFloorTile = serializedObject.FindProperty("randomFloorTile");

            _floorTile_1 = serializedObject.FindProperty("floorTile_1");
            _floorTile_2 = serializedObject.FindProperty("floorTile_2");
            _floorTile_3 = serializedObject.FindProperty("floorTile_3");
            _floorTile_4 = serializedObject.FindProperty("floorTile_4");
            _floorTile_5 = serializedObject.FindProperty("floorTile_5");
            _floorTile_6 = serializedObject.FindProperty("floorTile_6");
            _floorTile_7 = serializedObject.FindProperty("floorTile_7");
            _floorTile_8 = serializedObject.FindProperty("floorTile_8");
            _floorTile_9 = serializedObject.FindProperty("floorTile_9");
            _floorTile_10 = serializedObject.FindProperty("floorTile_10");
            _floorTile_11 = serializedObject.FindProperty("floorTile_11");
            _floorTile_12 = serializedObject.FindProperty("floorTile_12");
            _floorTile_13 = serializedObject.FindProperty("floorTile_13");
            _floorTile_14 = serializedObject.FindProperty("floorTile_14");
            _floorTile_15 = serializedObject.FindProperty("floorTile_15");

            _floorTile_C1 = serializedObject.FindProperty("floorTile_C1");
            _floorTile_C2 = serializedObject.FindProperty("floorTile_C2");
            _floorTile_C3 = serializedObject.FindProperty("floorTile_C3");
            _floorTile_C4 = serializedObject.FindProperty("floorTile_C4");
            _floorTile_C5 = serializedObject.FindProperty("floorTile_C5");
            _floorTile_C6 = serializedObject.FindProperty("floorTile_C6");
            _floorTile_C7 = serializedObject.FindProperty("floorTile_C7");
            _floorTile_C8 = serializedObject.FindProperty("floorTile_C8");
            _floorTile_C9 = serializedObject.FindProperty("floorTile_C9");
            _floorTile_C10 = serializedObject.FindProperty("floorTile_C10");
            _floorTile_C11 = serializedObject.FindProperty("floorTile_C11");
            _floorTile_C12 = serializedObject.FindProperty("floorTile_C12");
            _floorTile_C13 = serializedObject.FindProperty("floorTile_C13");
            _floorTile_C14 = serializedObject.FindProperty("floorTile_C14");
            _floorTile_C15 = serializedObject.FindProperty("floorTile_C15");
            _floorTile_C16 = serializedObject.FindProperty("floorTile_C16");
            _floorTile_C17 = serializedObject.FindProperty("floorTile_C17");
            _floorTile_C18 = serializedObject.FindProperty("floorTile_C18");
            _floorTile_C19 = serializedObject.FindProperty("floorTile_C19");
            _floorTile_C20 = serializedObject.FindProperty("floorTile_C20");
            _floorTile_C21 = serializedObject.FindProperty("floorTile_C21");
            _floorTile_C22 = serializedObject.FindProperty("floorTile_C22");
            _floorTile_C23 = serializedObject.FindProperty("floorTile_C23");
            _floorTile_C24 = serializedObject.FindProperty("floorTile_C24");
            _floorTile_C25 = serializedObject.FindProperty("floorTile_C25");
            _floorTile_C26 = serializedObject.FindProperty("floorTile_C26");
            _floorTile_C27 = serializedObject.FindProperty("floorTile_C27");
            _floorTile_C28 = serializedObject.FindProperty("floorTile_C28");
            _floorTile_C29 = serializedObject.FindProperty("floorTile_C29");
            _floorTile_C30 = serializedObject.FindProperty("floorTile_C30");
            _floorTile_C31 = serializedObject.FindProperty("floorTile_C31");

            _wallTile_1 = serializedObject.FindProperty("wallTile_1");
            _wallTile_2 = serializedObject.FindProperty("wallTile_2");
            _wallTile_3 = serializedObject.FindProperty("wallTile_3");
            _wallTile_4 = serializedObject.FindProperty("wallTile_4");
            _wallTile_5 = serializedObject.FindProperty("wallTile_5");
            _wallTile_6 = serializedObject.FindProperty("wallTile_6");
            _wallTile_7 = serializedObject.FindProperty("wallTile_7");
            _wallTile_8 = serializedObject.FindProperty("wallTile_8");
            _wallTile_9 = serializedObject.FindProperty("wallTile_9");
            _wallTile_10 = serializedObject.FindProperty("wallTile_10");
            _wallTile_11 = serializedObject.FindProperty("wallTile_11");
            _wallTile_12 = serializedObject.FindProperty("wallTile_12");
            _wallTile_13 = serializedObject.FindProperty("wallTile_13");
            _wallTile_14 = serializedObject.FindProperty("wallTile_14");
            _wallTile_15 = serializedObject.FindProperty("wallTile_15");

            _wallTile_C1 = serializedObject.FindProperty("wallTile_C1");
            _wallTile_C2 = serializedObject.FindProperty("wallTile_C2");
            _wallTile_C3 = serializedObject.FindProperty("wallTile_C3");
            _wallTile_C4 = serializedObject.FindProperty("wallTile_C4");
            _wallTile_C5 = serializedObject.FindProperty("wallTile_C5");
            _wallTile_C6 = serializedObject.FindProperty("wallTile_C6");
            _wallTile_C7 = serializedObject.FindProperty("wallTile_C7");
            _wallTile_C8 = serializedObject.FindProperty("wallTile_C8");
            _wallTile_C9 = serializedObject.FindProperty("wallTile_C9");
            _wallTile_C10 = serializedObject.FindProperty("wallTile_C10");
            _wallTile_C11 = serializedObject.FindProperty("wallTile_C11");
            _wallTile_C12 = serializedObject.FindProperty("wallTile_C12");
            _wallTile_C13 = serializedObject.FindProperty("wallTile_C13");
            _wallTile_C14 = serializedObject.FindProperty("wallTile_C14");
            _wallTile_C15 = serializedObject.FindProperty("wallTile_C15");
            _wallTile_C16 = serializedObject.FindProperty("wallTile_C16");
            _wallTile_C17 = serializedObject.FindProperty("wallTile_C17");
            _wallTile_C18 = serializedObject.FindProperty("wallTile_C18");
            _wallTile_C19 = serializedObject.FindProperty("wallTile_C19");
            _wallTile_C20 = serializedObject.FindProperty("wallTile_C20");
            _wallTile_C21 = serializedObject.FindProperty("wallTile_C21");
            _wallTile_C22 = serializedObject.FindProperty("wallTile_C22");
            _wallTile_C23 = serializedObject.FindProperty("wallTile_C23");
            _wallTile_C24 = serializedObject.FindProperty("wallTile_C24");
            _wallTile_C25 = serializedObject.FindProperty("wallTile_C25");
            _wallTile_C26 = serializedObject.FindProperty("wallTile_C26");
            _wallTile_C27 = serializedObject.FindProperty("wallTile_C27");
            _wallTile_C28 = serializedObject.FindProperty("wallTile_C28");
            _wallTile_C29 = serializedObject.FindProperty("wallTile_C29");
            _wallTile_C30 = serializedObject.FindProperty("wallTile_C30");
            _wallTile_C31 = serializedObject.FindProperty("wallTile_C31");

            _patternWallTile_1 = serializedObject.FindProperty("patternWallTile_1");
            _patternWallTile_2 = serializedObject.FindProperty("patternWallTile_2");
            _patternWallTile_3 = serializedObject.FindProperty("patternWallTile_3");
            _patternWallTile_4 = serializedObject.FindProperty("patternWallTile_4");
            _patternWallTile_5 = serializedObject.FindProperty("patternWallTile_5");
            _patternWallTile_6 = serializedObject.FindProperty("patternWallTile_6");
            _patternWallTile_7 = serializedObject.FindProperty("patternWallTile_7");
            _patternWallTile_8 = serializedObject.FindProperty("patternWallTile_8");
            _patternWallTile_9 = serializedObject.FindProperty("patternWallTile_9");
            _patternWallTile_10 = serializedObject.FindProperty("patternWallTile_10");
            _patternWallTile_11 = serializedObject.FindProperty("patternWallTile_11");
            _patternWallTile_12 = serializedObject.FindProperty("patternWallTile_12");
            _patternWallTile_13 = serializedObject.FindProperty("patternWallTile_13");
            _patternWallTile_14 = serializedObject.FindProperty("patternWallTile_14");
            _patternWallTile_15 = serializedObject.FindProperty("patternWallTile_15");

            _randomWallTile_1 = serializedObject.FindProperty("randomWallTile_1");
            _randomWallTile_2 = serializedObject.FindProperty("randomWallTile_2");
            _randomWallTile_3 = serializedObject.FindProperty("randomWallTile_3");
            _randomWallTile_4 = serializedObject.FindProperty("randomWallTile_4");
            _randomWallTile_5 = serializedObject.FindProperty("randomWallTile_5");
            _randomWallTile_6 = serializedObject.FindProperty("randomWallTile_6");
            _randomWallTile_7 = serializedObject.FindProperty("randomWallTile_7");
            _randomWallTile_8 = serializedObject.FindProperty("randomWallTile_8");
            _randomWallTile_9 = serializedObject.FindProperty("randomWallTile_9");
            _randomWallTile_10 = serializedObject.FindProperty("randomWallTile_10");
            _randomWallTile_11 = serializedObject.FindProperty("randomWallTile_11");
            _randomWallTile_12 = serializedObject.FindProperty("randomWallTile_12");
            _randomWallTile_13 = serializedObject.FindProperty("randomWallTile_13");
            _randomWallTile_14 = serializedObject.FindProperty("randomWallTile_14");
            _randomWallTile_15 = serializedObject.FindProperty("randomWallTile_15");


            //Level floor collider
            _createLevelSizedFloorCollider = serializedObject.FindProperty("createLevelSizedFloorCollider");
            _createWallCompositeCollider = serializedObject.FindProperty("createWall2DCompositeCollider");
            _deleteFloorBelowOverlay = serializedObject.FindProperty("deleteFloorBelowOverlay");
            _createWallGridCollider = serializedObject.FindProperty("createWallGridCollider");
            _levelColliderHeight = serializedObject.FindProperty("levelColliderHeight");
            _rotateLevel = serializedObject.FindProperty("levelRot");


            //Offset
            _floorOffset = serializedObject.FindProperty("floorOffset");
            _wallOffset = serializedObject.FindProperty("wallOffset");
            _overlayOffset = serializedObject.FindProperty("overlayOffset");
            _emptyOffset = serializedObject.FindProperty("emptyOffset");


            script = (RoguelikeGeneratorPro)target;
        }


        public override void OnInspectorGUI()
        {
            //styles
            alignGUILeft = new GUIStyle(GUI.skin.label) { alignment = TextAnchor.MiddleLeft };
            alignGUIRight = new GUIStyle(GUI.skin.label) { alignment = TextAnchor.MiddleRight };


            serializedObject.Update();
            EditorGUILayout.BeginVertical();


            //Level dimensions
            EditorGUILayout.Space(20);
            EditorGUILayout.LabelField("Level Dimensions", EditorStyles.boldLabel);
            EditorGUILayout.Space(5);


            #region LevelSize

            _levelSize.vector2IntValue = EditorGUILayout.Vector2IntField("Level Size", script.levelSize);

            #endregion
            

            #region TileSize

            _tileSize.floatValue = EditorGUILayout.FloatField("Tile Size", script.tileSize);

            #endregion


            #region PercentLevelToFill

            _percentLevelToFill.floatValue = EditorGUILayout.Slider("Percent To Fill", script.percentLevelToFill, 0f, 100f);

            #endregion


            #region SpawnCornerWalls

            _spawnCornerWalls.boolValue = EditorGUILayout.Toggle("Spawn Corner Walls", script.spawnCornerWalls);

            #endregion


            #region RemoveUnnaturalWalls

            _removeUnnaturalWalls.boolValue = EditorGUILayout.Toggle("Remove Unnatural Walls", script.removeUnnaturalWalls);

            #endregion


            #region UseSeed

            _useSeed.boolValue = EditorGUILayout.Toggle("Use seed", script.useSeed);

            #endregion


            #region GenerationSeed

            if (_useSeed.boolValue)
            {
                _generationSeed.intValue = EditorGUILayout.IntField("Generation Seed", script.generationSeed);
            }

            #endregion


            #region RigenerateLevel

            EditorGUILayout.Space();
            if (GUILayout.Button("Regenerate Level", GUILayout.Height(26))) script.RigenenerateLevel();

            #endregion


            //Pathmaker properties
            EditorGUILayout.Space(20);
            EditorGUILayout.LabelField("PathMaker properties", EditorStyles.boldLabel);
            EditorGUILayout.Space(5);


            #region PathMakerSpawnChance

            _pathMakerSpawnChance.intValue = EditorGUILayout.IntSlider("Spawn Chance", script.pathMakerSpawnChance, 0, 100);

            #endregion


            #region PathMakerDestructionChance

            _pathMakerDestructionChance.intValue = EditorGUILayout.IntSlider("Destruction Chance", script.pathMakerDestructionChance, 0, 100);

            #endregion


            #region PathMakerRotationChance

            _pathMakerRotationChance.intValue = EditorGUILayout.IntSlider("Rotation Chance", script.pathMakerRotationChance, 0, 100);

            #endregion


            #region PathMakerRotatesLeft

            _pathMakerRotatesLeft.floatValue = EditorGUILayout.Slider("Rotates Left", script.pathMakerRotatesLeft, 0f, 100f);

            #endregion


            #region PathMakerRotatesRight

            _pathMakerRotatesRight.floatValue = EditorGUILayout.Slider("Rotates Right", script.pathMakerRotatesRight, 0f, 100f);

            #endregion


            #region PathMakerRotatesBackwords

            _pathMakerRotatesBackwords.floatValue = EditorGUILayout.Slider("Rotates Backwords", script.pathMakerRotatesBackwords, 0f, 100f);

            #endregion


            #region PathMakerMaxDensity

            _pathMakerMaxDensity.intValue = EditorGUILayout.IntField("Density", script.pathMakerMaxDensity);

            #endregion


            //Chunk properties
            EditorGUILayout.Space(20);
            EditorGUILayout.LabelField("Chunk properties", EditorStyles.boldLabel);
            EditorGUILayout.Space(5);


            #region ChunckSpawnChance

            _chunkSpawnChance.intValue = EditorGUILayout.IntSlider("Spawn Chance", script.chunkSpawnChance, 0, 100);

            #endregion


            #region ChunckChance2x2

            _chunkChance2x2.floatValue = EditorGUILayout.Slider("Chance 2x2", script.chunkChance2x2, 0f, 100f);

            #endregion


            #region ChunckChance3x3

            _chunkChance3x3.floatValue = EditorGUILayout.Slider("Chance 3x3", script.chunkChance3x3, 0f, 100f);

            #endregion


            //Pattern floor overlay
            EditorGUILayout.Space(20);
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
            EditorGUILayout.Space(20);
            EditorGUILayout.LabelField("Floor pattern overlay", EditorStyles.boldLabel);
            EditorGUILayout.Space(5);


            #region PatternFloor

            _patternFloor.intValue = (int)(patternType)EditorGUILayout.EnumPopup("Pattern", script.patternFloor);

            #endregion


            #region NoiseScaleFloor

            _noiseScaleFloor.vector2Value = EditorGUILayout.Vector2Field("Noise Scale", script.noiseScaleFloor);

            #endregion


            #region NoiseCutoffFloor

            _noiseCutoffFloor.floatValue = EditorGUILayout.Slider("Noise Cutoff", script.noiseCutoffFloor, 0f, 1f);

            #endregion


            //Pattern wall overlay
            EditorGUILayout.Space(20);
            EditorGUILayout.LabelField("Wall pattern overlay", EditorStyles.boldLabel);
            EditorGUILayout.Space(5);


            #region PatternWall

            _patternWall.intValue = (int)(patternType)EditorGUILayout.EnumPopup("Pattern", script.patternWall);

            #endregion


            #region NoiseScaleWall

            _noiseScaleWall.vector2Value = EditorGUILayout.Vector2Field("Noise Scale", script.noiseScaleWall);

            #endregion


            #region NoiseCutoffWall

            _noiseCutoffWall.floatValue = EditorGUILayout.Slider("Noise Cutoff", script.noiseCutoffWall, 0f, 1f);

            #endregion


            //Random tiles overlay
            EditorGUILayout.Space(20);
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
            EditorGUILayout.Space(20);
            EditorGUILayout.LabelField("Floor random overlay", EditorStyles.boldLabel);
            EditorGUILayout.Space(5);


            #region RandomOverlayChance

            _randomFloorOverlayChance.intValue = EditorGUILayout.IntSlider("Spawn Chance", script.randomFloorOverlayChance, 0, 100);

            #endregion


            //Random tiles overlay
            EditorGUILayout.Space(20);
            EditorGUILayout.LabelField("Wall random overlay", EditorStyles.boldLabel);
            EditorGUILayout.Space(5);


            #region RandomOverlayChance

            _randomWallOverlayChance.intValue = EditorGUILayout.IntSlider("Spawn Chance", script.randomWallOverlayChance, 0, 100);

            #endregion


            //Spawn tiles
            EditorGUILayout.Space(20);
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
            EditorGUILayout.Space(20);
            _tabSelected.intValue = GUILayout.Toolbar(script.tabSelected, tabs);

            if (_tabSelected.intValue == 0)
            {
                _generation.intValue = 0;


                DrawEmpty(genType.generateObj);
                DrawFloorPatternOverlayTiles(genType.generateObj);
                DrawFloorRandomOverlayTiles(genType.generateObj);


                #region DrawTilesOrientation

                EditorGUILayout.Space(30);

                EditorGUILayout.BeginVertical(BackgroundStyle.Get(new Color(0f, 0f, 0f, 0.2f)));
                EditorGUILayout.Space(5);

                _drawTilesOrientation.boolValue = EditorGUILayout.Toggle("Draw Tiles Orientation", script.drawTilesOrientation);
                EditorGUILayout.Space();

                if (!_drawTilesOrientation.boolValue)
                {
                    EditorGUILayout.BeginVertical();


                    #region Floor and Wall

                    EditorGUILayout.Space(20);
                    DisplayTileObjBlock("Floor Tile - Generic", floorTileObj_1_txt, _floorTileObj_1, script.floorTileObj_1);

                    EditorGUILayout.Space(20);
                    DisplayTileObjBlock("Wall Tile - Generic", wallTileObj_1_txt, _wallTileObj_1, script.wallTileObj_1);

                    #endregion


                    //separator
                    EditorGUILayout.Space(20);
                    EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
                    EditorGUILayout.Space(20);


                    #region PatternWall

                    _drawWallOverlayPatternTiles.boolValue = EditorGUILayout.Toggle("Draw Wall Pattern", script.drawWallOverlayPatternTiles);
                    EditorGUILayout.Space();

                    if (_drawWallOverlayPatternTiles.boolValue) DisplayTileObjBlock("Wall Pattern - Generic", wallTilePatternObj_1_txt, _patternWallTileObj_1, script.patternWallTileObj_1);
                    else EditorGUILayout.Space(10);

                    #endregion


                    //separator
                    EditorGUILayout.Space(20);
                    EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
                    EditorGUILayout.Space(20);


                    #region RandomWall

                    _drawWallOverlayRandomTiles.boolValue = EditorGUILayout.Toggle("Draw Wall Random", script.drawWallOverlayRandomTiles);
                    EditorGUILayout.Space();

                    if (_drawWallOverlayRandomTiles.boolValue) DisplayTileObjBlock("Wall Random - Generic", wallTileRandomObj_1_txt, _randomWallTileObj_1, script.randomWallTileObj_1);
                    else EditorGUILayout.Space(10);

                    #endregion

                    EditorGUILayout.EndVertical();
                    EditorGUILayout.Space(10);
                }
                else
                {
                    _drawCorners.boolValue = EditorGUILayout.Toggle("Draw Corners", script.drawCorners);
                    _fillAllTiles.boolValue = EditorGUILayout.Toggle("Manually Set All Tiles", script.fillAllTiles);
                    EditorGUILayout.Space();


                    EditorGUILayout.BeginVertical();


                    #region Floor

                    EditorGUILayout.Space(20);
                    DisplayTileObjBlock("Floor Tile - Generic", floorTileObj_1_txt, _floorTileObj_1, script.floorTileObj_1);

                    EditorGUILayout.Space(20);
                    DisplayTileObjBlock("Floor Tile - 1 Side", floorTileObj_2_txt, _floorTileObj_2, script.floorTileObj_2);

                    if(_fillAllTiles.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 1 Side", floorTileObj_3_txt, _floorTileObj_3, script.floorTileObj_3);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 1 Side", floorTileObj_4_txt, _floorTileObj_4, script.floorTileObj_4);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 1 Side", floorTileObj_5_txt, _floorTileObj_5, script.floorTileObj_5);
                    }

                    EditorGUILayout.Space(20);
                    DisplayTileObjBlock("Floor Tile - 2 Corner Sides", floorTileObj_6_txt, _floorTileObj_6, script.floorTileObj_6);

                    if (_fillAllTiles.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 2 Corner Sides", floorTileObj_7_txt, _floorTileObj_7, script.floorTileObj_7);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 2 Corner Sides", floorTileObj_8_txt, _floorTileObj_8, script.floorTileObj_8);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 2 Corner Sides", floorTileObj_9_txt, _floorTileObj_9, script.floorTileObj_9);
                    }

                    EditorGUILayout.Space(20);
                    DisplayTileObjBlock("Floor Tile - 2 Opposite Sides", floorTileObj_10_txt, _floorTileObj_10, script.floorTileObj_10);

                    if (_fillAllTiles.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 2 Opposite Sides", floorTileObj_11_txt, _floorTileObj_11, script.floorTileObj_11);
                    }

                    EditorGUILayout.Space(20);
                    DisplayTileObjBlock("Floor Tile - 3 Sides", floorTileObj_12_txt, _floorTileObj_12, script.floorTileObj_12);

                    if (_fillAllTiles.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 3 Sides", floorTileObj_13_txt, _floorTileObj_13, script.floorTileObj_13);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 3 Sides", floorTileObj_14_txt, _floorTileObj_14, script.floorTileObj_14);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 3 Sides", floorTileObj_15_txt, _floorTileObj_15, script.floorTileObj_15);
                    }

                    if (_drawCorners.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 1 Corner", floorTileObj_C1_txt, _floorTileObj_C1, script.floorTileObj_C1);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 1 Corner", floorTileObj_C2_txt, _floorTileObj_C2, script.floorTileObj_C2);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 1 Corner", floorTileObj_C3_txt, _floorTileObj_C3, script.floorTileObj_C3);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 1 Corner", floorTileObj_C4_txt, _floorTileObj_C4, script.floorTileObj_C4);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 2 Corners", floorTileObj_C5_txt, _floorTileObj_C5, script.floorTileObj_C5);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 2 Corners", floorTileObj_C6_txt, _floorTileObj_C6, script.floorTileObj_C6);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 2 Corners", floorTileObj_C7_txt, _floorTileObj_C7, script.floorTileObj_C7);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 2 Corners", floorTileObj_C8_txt, _floorTileObj_C8, script.floorTileObj_C8);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 2 Opposite Corners", floorTileObj_C9_txt, _floorTileObj_C9, script.floorTileObj_C9);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 2 Opposite Corners", floorTileObj_C10_txt, _floorTileObj_C10, script.floorTileObj_C10);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 3 Corners", floorTileObj_C11_txt, _floorTileObj_C11, script.floorTileObj_C11);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 3 Corners", floorTileObj_C12_txt, _floorTileObj_C12, script.floorTileObj_C12);
                            
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 3 Corners", floorTileObj_C13_txt, _floorTileObj_C13, script.floorTileObj_C13);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 3 Corners", floorTileObj_C14_txt, _floorTileObj_C14, script.floorTileObj_C14);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 1 Side / Corner", floorTileObj_C15_txt, _floorTileObj_C15, script.floorTileObj_C15);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 1 Side / Corner", floorTileObj_C16_txt, _floorTileObj_C16, script.floorTileObj_C16);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 1 Side / Corner", floorTileObj_C17_txt, _floorTileObj_C17, script.floorTileObj_C17);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 1 Side / Corner", floorTileObj_C18_txt, _floorTileObj_C18, script.floorTileObj_C18);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 1 Side / Corner", floorTileObj_C19_txt, _floorTileObj_C19, script.floorTileObj_C19);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 1 Side / Corner", floorTileObj_C20_txt, _floorTileObj_C20, script.floorTileObj_C20);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 1 Side / Corner", floorTileObj_C21_txt, _floorTileObj_C21, script.floorTileObj_C21);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 1 Side / Corner", floorTileObj_C22_txt, _floorTileObj_C22, script.floorTileObj_C22);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 1 Side / Corner", floorTileObj_C23_txt, _floorTileObj_C23, script.floorTileObj_C23);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 1 Side / Corner", floorTileObj_C24_txt, _floorTileObj_C24, script.floorTileObj_C24);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 1 Side / Corner", floorTileObj_C25_txt, _floorTileObj_C25, script.floorTileObj_C25);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Floor Tile - 1 Side / Corner", floorTileObj_C26_txt, _floorTileObj_C26, script.floorTileObj_C26);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 2 Sides / Corner", floorTileObj_C27_txt, _floorTileObj_C27, script.floorTileObj_C27);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 2 Sides / Corner", floorTileObj_C28_txt, _floorTileObj_C28, script.floorTileObj_C28);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 2 Sides / Corner", floorTileObj_C29_txt, _floorTileObj_C29, script.floorTileObj_C29);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 2 Sides / Corner", floorTileObj_C30_txt, _floorTileObj_C30, script.floorTileObj_C30);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Floor Tile - 4 Corners", floorTileObj_C31_txt, _floorTileObj_C31, script.floorTileObj_C31);
                    }

                    #endregion


                    #region Wall

                    EditorGUILayout.Space(20);
                    DisplayTileObjBlock("Wall Tile - Generic", wallTileObj_1_txt, _wallTileObj_1, script.wallTileObj_1);

                    EditorGUILayout.Space(20);
                    DisplayTileObjBlock("Wall Tile - 1 Side", wallTileObj_2_txt, _wallTileObj_2, script.wallTileObj_2);

                    if (_fillAllTiles.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 1 Side", wallTileObj_3_txt, _wallTileObj_3, script.wallTileObj_3);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 1 Side", wallTileObj_4_txt, _wallTileObj_4, script.wallTileObj_4);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 1 Side", wallTileObj_5_txt, _wallTileObj_5, script.wallTileObj_5);
                    }

                    EditorGUILayout.Space(20);
                    DisplayTileObjBlock("Wall Tile - 2 Corner Sides", wallTileObj_6_txt, _wallTileObj_6, script.wallTileObj_6);

                    if (_fillAllTiles.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 2 Corner Sides", wallTileObj_7_txt, _wallTileObj_7, script.wallTileObj_7);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 2 Corner Sides", wallTileObj_8_txt, _wallTileObj_8, script.wallTileObj_8);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 2 Corner Sides", wallTileObj_9_txt, _wallTileObj_9, script.wallTileObj_9);
                    }

                    EditorGUILayout.Space(20);
                    DisplayTileObjBlock("Wall Tile - 2 Opposite Sides", wallTileObj_10_txt, _wallTileObj_10, script.wallTileObj_10);

                    if (_fillAllTiles.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 2 Opposite Sides", wallTileObj_11_txt, _wallTileObj_11, script.wallTileObj_11);
                    }

                    EditorGUILayout.Space(20);
                    DisplayTileObjBlock("Wall Tile - 3 Sides", wallTileObj_12_txt, _wallTileObj_12, script.wallTileObj_12);

                    if (_fillAllTiles.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 3 Sides", wallTileObj_13_txt, _wallTileObj_13, script.wallTileObj_13);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 3 Sides", wallTileObj_14_txt, _wallTileObj_14, script.wallTileObj_14);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 3 Sides", wallTileObj_15_txt, _wallTileObj_15, script.wallTileObj_15);
                    }

                    if (_drawCorners.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 1 Corner", wallTileObj_C1_txt, _wallTileObj_C1, script.wallTileObj_C1);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 1 Corner", wallTileObj_C2_txt, _wallTileObj_C2, script.wallTileObj_C2);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 1 Corner", wallTileObj_C3_txt, _wallTileObj_C3, script.wallTileObj_C3);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 1 Corner", wallTileObj_C4_txt, _wallTileObj_C4, script.wallTileObj_C4);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 2 Corners", wallTileObj_C5_txt, _wallTileObj_C5, script.wallTileObj_C5);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 2 Corners", wallTileObj_C6_txt, _wallTileObj_C6, script.wallTileObj_C6);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 2 Corners", wallTileObj_C7_txt, _wallTileObj_C7, script.wallTileObj_C7);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 2 Corners", wallTileObj_C8_txt, _wallTileObj_C8, script.wallTileObj_C8);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 2 Opposite Corners", wallTileObj_C9_txt, _wallTileObj_C9, script.wallTileObj_C9);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 2 Opposite Corners", wallTileObj_C10_txt, _wallTileObj_C10, script.wallTileObj_C10);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 3 Corners", wallTileObj_C11_txt, _wallTileObj_C11, script.wallTileObj_C11);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 3 Corners", wallTileObj_C12_txt, _wallTileObj_C12, script.wallTileObj_C12);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 3 Corners", wallTileObj_C13_txt, _wallTileObj_C13, script.wallTileObj_C13);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 3 Corners", wallTileObj_C14_txt, _wallTileObj_C14, script.wallTileObj_C14);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 1 Side / Corner", wallTileObj_C15_txt, _wallTileObj_C15, script.wallTileObj_C15);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 1 Side / Corner", wallTileObj_C16_txt, _wallTileObj_C16, script.wallTileObj_C16);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 1 Side / Corner", wallTileObj_C17_txt, _wallTileObj_C17, script.wallTileObj_C17);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 1 Side / Corner", wallTileObj_C18_txt, _wallTileObj_C18, script.wallTileObj_C18);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 1 Side / Corner", wallTileObj_C19_txt, _wallTileObj_C19, script.wallTileObj_C19);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 1 Side / Corner", wallTileObj_C20_txt, _wallTileObj_C20, script.wallTileObj_C20);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 1 Side / Corner", wallTileObj_C21_txt, _wallTileObj_C21, script.wallTileObj_C21);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 1 Side / Corner", wallTileObj_C22_txt, _wallTileObj_C22, script.wallTileObj_C22);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 1 Side / Corner", wallTileObj_C23_txt, _wallTileObj_C23, script.wallTileObj_C23);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 1 Side / Corner", wallTileObj_C24_txt, _wallTileObj_C24, script.wallTileObj_C24);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 1 Side / Corner", wallTileObj_C25_txt, _wallTileObj_C25, script.wallTileObj_C25);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Tile - 1 Side / Corner", wallTileObj_C26_txt, _wallTileObj_C26, script.wallTileObj_C26);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 2 Sides / Corner", wallTileObj_C27_txt, _wallTileObj_C27, script.wallTileObj_C27);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 2 Sides / Corner", wallTileObj_C28_txt, _wallTileObj_C28, script.wallTileObj_C28);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 2 Sides / Corner", wallTileObj_C29_txt, _wallTileObj_C29, script.wallTileObj_C29);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 2 Sides / Corner", wallTileObj_C30_txt, _wallTileObj_C30, script.wallTileObj_C30);

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Tile - 4 Corners", wallTileObj_C31_txt, _wallTileObj_C31, script.wallTileObj_C31);
                    }

                    #endregion


                    //separator
                    EditorGUILayout.Space(20);
                    EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
                    EditorGUILayout.Space(20);


                    #region PatternWall

                    _drawWallOverlayPatternTiles.boolValue = EditorGUILayout.Toggle("Draw Wall Pattern", script.drawWallOverlayPatternTiles);
                    EditorGUILayout.Space();

                    if(_drawWallOverlayPatternTiles.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Pattern - 1 Side", wallTilePatternObj_2_txt, _patternWallTileObj_2, script.patternWallTileObj_2);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Pattern - 1 Side", wallTilePatternObj_3_txt, _patternWallTileObj_3, script.patternWallTileObj_3);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Pattern - 1 Side", wallTilePatternObj_4_txt, _patternWallTileObj_4, script.patternWallTileObj_4);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Pattern - 1 Side", wallTilePatternObj_5_txt, _patternWallTileObj_5, script.patternWallTileObj_5);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Pattern - 2 Corner Sides", wallTilePatternObj_6_txt, _patternWallTileObj_6, script.patternWallTileObj_6);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Pattern - 2 Corner Sides", wallTilePatternObj_7_txt, _patternWallTileObj_7, script.patternWallTileObj_7);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Pattern - 2 Corner Sides", wallTilePatternObj_8_txt, _patternWallTileObj_8, script.patternWallTileObj_8);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Pattern - 2 Corner Sides", wallTilePatternObj_9_txt, _patternWallTileObj_9, script.patternWallTileObj_9);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Pattern - 2 Opposite Sides", wallTilePatternObj_10_txt, _patternWallTileObj_10, script.patternWallTileObj_10);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Pattern - 2 Opposite Sides", wallTilePatternObj_11_txt, _patternWallTileObj_11, script.patternWallTileObj_11);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Pattern - 3 Sides", wallTilePatternObj_12_txt, _patternWallTileObj_12, script.patternWallTileObj_12);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Pattern - 3 Sides", wallTilePatternObj_13_txt, _patternWallTileObj_13, script.patternWallTileObj_13);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Pattern - 3 Sides", wallTilePatternObj_14_txt, _patternWallTileObj_14, script.patternWallTileObj_14);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Pattern - 3 Sides", wallTilePatternObj_15_txt, _patternWallTileObj_15, script.patternWallTileObj_15);
                        }
                    }

                    #endregion


                    //separator
                    EditorGUILayout.Space(20);
                    EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
                    EditorGUILayout.Space(20);


                    #region RandomWall

                    _drawWallOverlayRandomTiles.boolValue = EditorGUILayout.Toggle("Draw Wall Random", script.drawWallOverlayRandomTiles);
                    EditorGUILayout.Space();

                    if (_drawWallOverlayRandomTiles.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Random - 1 Side", wallTileRandomObj_2_txt, _randomWallTileObj_2, script.randomWallTileObj_2);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Random - 1 Side", wallTileRandomObj_3_txt, _randomWallTileObj_3, script.randomWallTileObj_3);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Random - 1 Side", wallTileRandomObj_4_txt, _randomWallTileObj_4, script.randomWallTileObj_4);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Random - 1 Side", wallTileRandomObj_5_txt, _randomWallTileObj_5, script.randomWallTileObj_5);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Random - 2 Corner Sides", wallTileRandomObj_6_txt, _randomWallTileObj_6, script.randomWallTileObj_6);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Random - 2 Corner Sides", wallTileRandomObj_7_txt, _randomWallTileObj_7, script.randomWallTileObj_7);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Random - 2 Corner Sides", wallTileRandomObj_8_txt, _randomWallTileObj_8, script.randomWallTileObj_8);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Random - 2 Corner Sides", wallTileRandomObj_9_txt, _randomWallTileObj_9, script.randomWallTileObj_9);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Random - 2 Opposite Sides", wallTileRandomObj_10_txt, _randomWallTileObj_10, script.randomWallTileObj_10);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Random - 2 Opposite Sides", wallTileRandomObj_11_txt, _randomWallTileObj_11, script.randomWallTileObj_11);
                        }

                        EditorGUILayout.Space(20);
                        DisplayTileObjBlock("Wall Random - 3 Sides", wallTileRandomObj_12_txt, _randomWallTileObj_12, script.randomWallTileObj_12);

                        if (_fillAllTiles.boolValue)
                        {
                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Random - 3 Sides", wallTileRandomObj_13_txt, _randomWallTileObj_13, script.randomWallTileObj_13);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Random - 3 Sides", wallTileRandomObj_14_txt, _randomWallTileObj_14, script.randomWallTileObj_14);

                            EditorGUILayout.Space(20);
                            DisplayTileObjBlock("Wall Random - 3 Sides", wallTileRandomObj_15_txt, _randomWallTileObj_15, script.randomWallTileObj_15);
                        }
                    }

                    #endregion


                    EditorGUILayout.EndVertical();
                    EditorGUILayout.Space(10);
                }

                EditorGUILayout.EndVertical();

                #endregion


                //Level colliders
                EditorGUILayout.Space(20);
                EditorGUILayout.LabelField("Collision properties", EditorStyles.boldLabel);
                EditorGUILayout.Space(5);


                #region CreateLevelSizedFloorCollider

                _createLevelSizedFloorCollider.boolValue = EditorGUILayout.Toggle("Create Floor Collider", script.createLevelSizedFloorCollider);
                if (_createLevelSizedFloorCollider.boolValue) _levelColliderHeight.floatValue = EditorGUILayout.FloatField("Floor Collider Height", script.levelColliderHeight);

                #endregion


                #region CreateCompositeCollider2D

                _createWallCompositeCollider.boolValue = EditorGUILayout.Toggle("Create Wall 2D Composite Collider", script.createWall2DCompositeCollider);

                #endregion


                #region DeleteFloorBelow

                _deleteFloorBelowOverlay.boolValue = EditorGUILayout.Toggle("Delete Floor Below Overlay", script.deleteFloorBelowOverlay);

                #endregion


                LayerOffsets();


                #region RotateLevel

                _rotateLevel.intValue = (int)(patternType)EditorGUILayout.EnumPopup("Level Rotation", script.levelRot);

                #endregion
            }
            else if (_tabSelected.intValue == 1)
            {
                _generation.intValue = 1;


                DrawEmpty(genType.generateTile);
                DrawFloorPatternOverlayTiles(genType.generateTile);
                DrawFloorRandomOverlayTiles(genType.generateTile);


                #region DrawTilesOrientation

                EditorGUILayout.Space(30);

                EditorGUILayout.BeginVertical(BackgroundStyle.Get(new Color(0f, 0f, 0f, 0.2f)));
                EditorGUILayout.Space(5);

                _drawTilesOrientation.boolValue = EditorGUILayout.Toggle("Draw Tiles Orientation", script.drawTilesOrientation);
                EditorGUILayout.Space();

                if (!_drawTilesOrientation.boolValue)
                {
                    EditorGUILayout.BeginVertical();


                    #region Floor and Wall

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - Generic", floorTileObj_1_txt, _floorTile_1, script.floorTile_1);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - Generic", wallTileObj_1_txt, _wallTile_1, script.wallTile_1);

                    #endregion


                    //separator
                    EditorGUILayout.Space(20);
                    EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
                    EditorGUILayout.Space(20);


                    #region PatternWall

                    _drawWallOverlayPatternTiles.boolValue = EditorGUILayout.Toggle("Draw Wall Pattern", script.drawWallOverlayPatternTiles);
                    EditorGUILayout.Space();

                    if (_drawWallOverlayPatternTiles.boolValue) DisplayTileBlock("Wall Pattern - Generic", wallTilePatternObj_1_txt, _patternWallTile_1, script.patternWallTile_1);
                    else EditorGUILayout.Space(10);

                    #endregion


                    //separator
                    EditorGUILayout.Space(20);
                    EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
                    EditorGUILayout.Space(20);


                    #region RandomWall

                    _drawWallOverlayRandomTiles.boolValue = EditorGUILayout.Toggle("Draw Wall Random", script.drawWallOverlayRandomTiles);
                    EditorGUILayout.Space();

                    if (_drawWallOverlayRandomTiles.boolValue) DisplayTileBlock("Wall Random - Generic", wallTileRandomObj_1_txt, _randomWallTile_1, script.randomWallTile_1);
                    else EditorGUILayout.Space(10);

                    #endregion

                    EditorGUILayout.EndVertical();
                    EditorGUILayout.Space(10);
                }
                else
                {
                    _drawCorners.boolValue = EditorGUILayout.Toggle("Draw Corners", script.drawCorners);
                    EditorGUILayout.Space();


                    EditorGUILayout.BeginVertical();


                    #region Floor

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - Generic", floorTileObj_1_txt, _floorTile_1, script.floorTile_1);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - 1 Side", floorTileObj_2_txt, _floorTile_2, script.floorTile_2);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - 1 Side", floorTileObj_3_txt, _floorTile_3, script.floorTile_3);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - 1 Side", floorTileObj_4_txt, _floorTile_4, script.floorTile_4);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - 1 Side", floorTileObj_5_txt, _floorTile_5, script.floorTile_5);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - 2 Corner Sides", floorTileObj_6_txt, _floorTile_6, script.floorTile_6);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - 2 Corner Sides", floorTileObj_7_txt, _floorTile_7, script.floorTile_7);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - 2 Corner Sides", floorTileObj_8_txt, _floorTile_8, script.floorTile_8);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - 2 Corner Sides", floorTileObj_9_txt, _floorTile_9, script.floorTile_9);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - 2 Opposite Sides", floorTileObj_10_txt, _floorTile_10, script.floorTile_10);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - 2 Opposite Sides", floorTileObj_11_txt, _floorTile_11, script.floorTile_11);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - 3 Sides", floorTileObj_12_txt, _floorTile_12, script.floorTile_12);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - 3 Sides", floorTileObj_13_txt, _floorTile_13, script.floorTile_13);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - 3 Sides", floorTileObj_14_txt, _floorTile_14, script.floorTile_14);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Floor Tile - 3 Sides", floorTileObj_15_txt, _floorTile_15, script.floorTile_15);

                    if (_drawCorners.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Corner", floorTileObj_C1_txt, _floorTile_C1, script.floorTile_C1);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Corner", floorTileObj_C2_txt, _floorTile_C2, script.floorTile_C2);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Corner", floorTileObj_C3_txt, _floorTile_C3, script.floorTile_C3);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Corner", floorTileObj_C4_txt, _floorTile_C4, script.floorTile_C4);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 2 Corners", floorTileObj_C5_txt, _floorTile_C5, script.floorTile_C5);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 2 Corners", floorTileObj_C6_txt, _floorTile_C6, script.floorTile_C6);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 2 Corners", floorTileObj_C7_txt, _floorTile_C7, script.floorTile_C7);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 2 Corners", floorTileObj_C8_txt, _floorTile_C8, script.floorTile_C8);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 2 Corners Opposites", floorTileObj_C9_txt, _floorTile_C9, script.floorTile_C9);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 2 Corner Opposites", floorTileObj_C10_txt, _floorTile_C10, script.floorTile_C10);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 3 Corners", floorTileObj_C11_txt, _floorTile_C11, script.floorTile_C11);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 3 Corners", floorTileObj_C12_txt, _floorTile_C12, script.floorTile_C12);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 3 Corners", floorTileObj_C13_txt, _floorTile_C13, script.floorTile_C13);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 3 Corners", floorTileObj_C14_txt, _floorTile_C14, script.floorTile_C14);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Side / Corner", floorTileObj_C15_txt, _floorTile_C15, script.floorTile_C15);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Side / Corner", floorTileObj_C16_txt, _floorTile_C16, script.floorTile_C16);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Side / Corner", floorTileObj_C17_txt, _floorTile_C17, script.floorTile_C17);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Side / Corner", floorTileObj_C18_txt, _floorTile_C18, script.floorTile_C18);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Side / Corner", floorTileObj_C19_txt, _floorTile_C19, script.floorTile_C19);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Side / Corner", floorTileObj_C20_txt, _floorTile_C20, script.floorTile_C20);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Side / Corner", floorTileObj_C21_txt, _floorTile_C21, script.floorTile_C21);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Side / Corner", floorTileObj_C22_txt, _floorTile_C22, script.floorTile_C22);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Side / Corner", floorTileObj_C23_txt, _floorTile_C23, script.floorTile_C23);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Side / Corner", floorTileObj_C24_txt, _floorTile_C24, script.floorTile_C24);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Side / Corner", floorTileObj_C25_txt, _floorTile_C25, script.floorTile_C25);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 1 Side / Corner", floorTileObj_C26_txt, _floorTile_C26, script.floorTile_C26);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 2 Sides / Corner", floorTileObj_C27_txt, _floorTile_C27, script.floorTile_C27);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 2 Sides / Corner", floorTileObj_C28_txt, _floorTile_C28, script.floorTile_C28);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 2 Sides / Corner", floorTileObj_C29_txt, _floorTile_C29, script.floorTile_C29);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 2 Sides / Corner", floorTileObj_C30_txt, _floorTile_C30, script.floorTile_C30);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Floor Tile - 4 Corners", floorTileObj_C31_txt, _floorTile_C31, script.floorTile_C31);
                    }

                    #endregion


                    #region Wall

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - Generic", wallTileObj_1_txt, _wallTile_1, script.wallTile_1);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - 1 Side", wallTileObj_2_txt, _wallTile_2, script.wallTile_2);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - 1 Side", wallTileObj_3_txt, _wallTile_3, script.wallTile_3);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - 1 Side", wallTileObj_4_txt, _wallTile_4, script.wallTile_4);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - 1 Side", wallTileObj_5_txt, _wallTile_5, script.wallTile_5);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - 2 Corner Sides", wallTileObj_6_txt, _wallTile_6, script.wallTile_6);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - 2 Corner Sides", wallTileObj_7_txt, _wallTile_7, script.wallTile_7);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - 2 Corner Sides", wallTileObj_8_txt, _wallTile_8, script.wallTile_8);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - 2 Corner Sides", wallTileObj_9_txt, _wallTile_9, script.wallTile_9);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - 2 Opposite Sides", wallTileObj_10_txt, _wallTile_10, script.wallTile_10);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - 2 Opposite Sides", wallTileObj_11_txt, _wallTile_11, script.wallTile_11);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - 3 Sides", wallTileObj_12_txt, _wallTile_12, script.wallTile_12);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - 3 Sides", wallTileObj_13_txt, _wallTile_13, script.wallTile_13);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - 3 Sides", wallTileObj_14_txt, _wallTile_14, script.wallTile_14);

                    EditorGUILayout.Space(20);
                    DisplayTileBlock("Wall Tile - 3 Sides", wallTileObj_15_txt, _wallTile_15, script.wallTile_15);

                    if (_drawCorners.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Corner", wallTileObj_C1_txt, _wallTile_C1, script.wallTile_C1);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Corner", wallTileObj_C2_txt, _wallTile_C2, script.wallTile_C2);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Corner", wallTileObj_C3_txt, _wallTile_C3, script.wallTile_C3);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Corner", wallTileObj_C4_txt, _wallTile_C4, script.wallTile_C4);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 2 Corners", wallTileObj_C5_txt, _wallTile_C5, script.wallTile_C5);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 2 Corners", wallTileObj_C6_txt, _wallTile_C6, script.wallTile_C6);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 2 Corners", wallTileObj_C7_txt, _wallTile_C7, script.wallTile_C7);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 2 Corners", wallTileObj_C8_txt, _wallTile_C8, script.wallTile_C8);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 2 Corners Opposites", wallTileObj_C9_txt, _wallTile_C9, script.wallTile_C9);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 2 Corner Opposites", wallTileObj_C10_txt, _wallTile_C10, script.wallTile_C10);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 3 Corners", wallTileObj_C11_txt, _wallTile_C11, script.wallTile_C11);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 3 Corners", wallTileObj_C12_txt, _wallTile_C12, script.wallTile_C12);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 3 Corners", wallTileObj_C13_txt, _wallTile_C13, script.wallTile_C13);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 3 Corners", wallTileObj_C14_txt, _wallTile_C14, script.wallTile_C14);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Side / Corner", wallTileObj_C15_txt, _wallTile_C15, script.wallTile_C15);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Side / Corner", wallTileObj_C16_txt, _wallTile_C16, script.wallTile_C16);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Side / Corner", wallTileObj_C17_txt, _wallTile_C17, script.wallTile_C17);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Side / Corner", wallTileObj_C18_txt, _wallTile_C18, script.wallTile_C18);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Side / Corner", wallTileObj_C19_txt, _wallTile_C19, script.wallTile_C19);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Side / Corner", wallTileObj_C20_txt, _wallTile_C20, script.wallTile_C20);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Side / Corner", wallTileObj_C21_txt, _wallTile_C21, script.wallTile_C21);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Side / Corner", wallTileObj_C22_txt, _wallTile_C22, script.wallTile_C22);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Side / Corner", wallTileObj_C23_txt, _wallTile_C23, script.wallTile_C23);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Side / Corner", wallTileObj_C24_txt, _wallTile_C24, script.wallTile_C24);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Side / Corner", wallTileObj_C25_txt, _wallTile_C25, script.wallTile_C25);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 1 Side / Corner", wallTileObj_C26_txt, _wallTile_C26, script.wallTile_C26);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 2 Sides / Corner", wallTileObj_C27_txt, _wallTile_C27, script.wallTile_C27);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 2 Sides / Corner", wallTileObj_C28_txt, _wallTile_C28, script.wallTile_C28);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 2 Sides / Corner", wallTileObj_C29_txt, _wallTile_C29, script.wallTile_C29);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 2 Sides / Corner", wallTileObj_C30_txt, _wallTile_C30, script.wallTile_C30);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Tile - 4 Corners", wallTileObj_C31_txt, _wallTile_C31, script.wallTile_C31);
                    }

                    #endregion


                    //separator
                    EditorGUILayout.Space(20);
                    EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
                    EditorGUILayout.Space(20);


                    #region PatternWall

                    _drawWallOverlayPatternTiles.boolValue = EditorGUILayout.Toggle("Draw Wall Pattern", script.drawWallOverlayPatternTiles);
                    EditorGUILayout.Space();

                    if (_drawWallOverlayPatternTiles.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Pattern - 1 Side", wallTilePatternObj_2_txt, _patternWallTile_2, script.patternWallTile_2);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Pattern - 1 Side", wallTilePatternObj_3_txt, _patternWallTile_3, script.patternWallTile_3);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Pattern - 1 Side", wallTilePatternObj_4_txt, _patternWallTile_4, script.patternWallTile_4);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Pattern - 1 Side", wallTilePatternObj_5_txt, _patternWallTile_5, script.patternWallTile_5);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Pattern - 1 Side", wallTilePatternObj_6_txt, _patternWallTile_6, script.patternWallTile_6);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Pattern - 2 Corner Sides", wallTilePatternObj_7_txt, _patternWallTile_7, script.patternWallTile_7);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Pattern - 2 Corner Sides", wallTilePatternObj_8_txt, _patternWallTile_8, script.patternWallTile_8);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Pattern - 2 Corner Sides", wallTilePatternObj_9_txt, _patternWallTile_9, script.patternWallTile_9);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Pattern - 2 Corner Sides", wallTilePatternObj_10_txt, _patternWallTile_10, script.patternWallTile_10);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Pattern - 2 Opposite Sides", wallTilePatternObj_11_txt, _patternWallTile_11, script.patternWallTile_11);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Pattern - 2 Opposite Sides", wallTilePatternObj_12_txt, _patternWallTile_12, script.patternWallTile_12);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Pattern - 3 Sides", wallTilePatternObj_13_txt, _patternWallTile_13, script.patternWallTile_13);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Pattern - 3 Sides", wallTilePatternObj_14_txt, _patternWallTile_14, script.patternWallTile_14);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Pattern - 3 Sides", wallTilePatternObj_15_txt, _patternWallTile_15, script.patternWallTile_15);
                    }

                    #endregion


                    //separator
                    EditorGUILayout.Space(20);
                    EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
                    EditorGUILayout.Space(20);


                    #region RandomWall

                    _drawWallOverlayRandomTiles.boolValue = EditorGUILayout.Toggle("Draw Wall Random", script.drawWallOverlayRandomTiles);
                    EditorGUILayout.Space();

                    if (_drawWallOverlayRandomTiles.boolValue)
                    {
                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Random - 1 Side", wallTileRandomObj_2_txt, _randomWallTile_2, script.randomWallTile_2);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Random - 1 Side", wallTileRandomObj_3_txt, _randomWallTile_3, script.randomWallTile_3);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Random - 1 Side", wallTileRandomObj_4_txt, _randomWallTile_4, script.randomWallTile_4);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Random - 1 Side", wallTileRandomObj_5_txt, _randomWallTile_5, script.randomWallTile_5);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Random - 1 Side", wallTileRandomObj_6_txt, _randomWallTile_6, script.randomWallTile_6);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Random - 2 Corner Sides", wallTileRandomObj_7_txt, _randomWallTile_7, script.randomWallTile_7);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Random - 2 Corner Sides", wallTileRandomObj_8_txt, _randomWallTile_8, script.randomWallTile_8);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Random - 2 Corner Sides", wallTileRandomObj_9_txt, _randomWallTile_9, script.randomWallTile_9);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Random - 2 Corner Sides", wallTileRandomObj_10_txt, _randomWallTile_10, script.randomWallTile_10);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Random - 2 Opposite Sides", wallTileRandomObj_11_txt, _randomWallTile_11, script.randomWallTile_11);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Random - 2 Opposite Sides", wallTileRandomObj_12_txt, _randomWallTile_12, script.randomWallTile_12);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Random - 3 Sides", wallTileRandomObj_13_txt, _randomWallTile_13, script.randomWallTile_13);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Random - 3 Sides", wallTileRandomObj_14_txt, _randomWallTile_14, script.randomWallTile_14);

                        EditorGUILayout.Space(20);
                        DisplayTileBlock("Wall Random - 3 Sides", wallTileRandomObj_15_txt, _randomWallTile_15, script.randomWallTile_15);
                    }

                    #endregion


                    EditorGUILayout.EndVertical();
                    EditorGUILayout.Space(10);
                }

                EditorGUILayout.EndVertical();

                #endregion


                //Level colliders
                EditorGUILayout.Space(20);
                EditorGUILayout.LabelField("Collision properties", EditorStyles.boldLabel);
                EditorGUILayout.Space(5);


                #region CreateWallCollider

                _createWallGridCollider.boolValue = EditorGUILayout.Toggle("Create Wall Collider", script.createWallGridCollider);

                #endregion


                LayerOffsets();
            }
            else _generation.intValue = 2;

            script.generation = (genType)_generation.intValue;
            EditorGUILayout.Space(40);

            EditorGUILayout.EndVertical();
            serializedObject.ApplyModifiedProperties();
        }


        private void DrawEmpty(genType _generation)
        {
            EditorGUILayout.Space(30);

            EditorGUILayout.BeginVertical(BackgroundStyle.Get(new Color(0f, 0f, 0f, 0.2f)));
            EditorGUILayout.Space(5);

            _drawEmptyTiles.boolValue = EditorGUILayout.Toggle("Draw Empty Tiles", script.drawEmptyTiles);
            EditorGUILayout.Space();

            if (_drawEmptyTiles.boolValue)
            {
                EditorGUILayout.BeginHorizontal();

                EditorGUILayout.BeginVertical();
                GUILayout.Label("Empty Tile", alignGUILeft, GUILayout.ExpandWidth(true));

                if(_generation == genType.generateObj) _emptyTileObj.objectReferenceValue = EditorGUILayout.ObjectField(script.emptyTileObj, typeof(GameObject), true) as GameObject;
                else _emptyTile.objectReferenceValue = EditorGUILayout.ObjectField(script.emptyTile, typeof(Tile), true) as Tile;

                EditorGUILayout.EndVertical();
                GUILayout.Label(empty_txt, alignGUIRight, GUILayout.ExpandWidth(true));

                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Space(10);
            }

            EditorGUILayout.EndVertical();

        }


        private void DrawFloorPatternOverlayTiles(genType _generation)
        {
            EditorGUILayout.Space(30);

            EditorGUILayout.BeginVertical(BackgroundStyle.Get(new Color(0f, 0f, 0f, 0.2f)));
            EditorGUILayout.Space(5);

            _drawFloorOverlayPatternTiles.boolValue = EditorGUILayout.Toggle("Draw Floor Pattern", script.drawFloorOverlayPatternTiles);
            EditorGUILayout.Space();

            if (_drawFloorOverlayPatternTiles.boolValue)
            {
                //block 1
                EditorGUILayout.BeginHorizontal();

                EditorGUILayout.BeginVertical();
                GUILayout.Label("Floor Pattern Tile", alignGUILeft, GUILayout.ExpandWidth(true));
                
                if(_generation == genType.generateObj) _patternFloorTileObj.objectReferenceValue = EditorGUILayout.ObjectField(script.patternFloorTileObj, typeof(GameObject), true) as GameObject;
                else _patternFloorTile.objectReferenceValue = EditorGUILayout.ObjectField(script.patternFloorTile, typeof(Tile), true) as Tile;

                EditorGUILayout.EndVertical();
                GUILayout.Label(overlayPatternFloor_txt, alignGUIRight, GUILayout.ExpandWidth(true));

                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Space(10);
            }

            EditorGUILayout.EndVertical();
        }


        private void DrawFloorRandomOverlayTiles(genType _generation)
        {
            EditorGUILayout.Space(30);

            EditorGUILayout.BeginVertical(BackgroundStyle.Get(new Color(0f, 0f, 0f, 0.2f)));
            EditorGUILayout.Space(5);

            _drawFloorOverlayRandomTiles.boolValue = EditorGUILayout.Toggle("Draw Floor Random", script.drawFloorOverlayRandomTiles);
            EditorGUILayout.Space();

            if (_drawFloorOverlayRandomTiles.boolValue)
            {
                //block 1
                EditorGUILayout.BeginHorizontal();

                EditorGUILayout.BeginVertical();
                GUILayout.Label("Floor Random Tile", alignGUILeft, GUILayout.ExpandWidth(true));

                if (_generation == genType.generateObj) _randomFloorTileObj.objectReferenceValue = EditorGUILayout.ObjectField(script.randomFloorTileObj, typeof(GameObject), true) as GameObject;
                else _randomFloorTile.objectReferenceValue = EditorGUILayout.ObjectField(script.randomFloorTile, typeof(Tile), true) as Tile;

                EditorGUILayout.EndVertical();
                GUILayout.Label(overlayRandomFloor_txt, alignGUIRight, GUILayout.ExpandWidth(true));

                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Space(10);
            }

            EditorGUILayout.EndVertical();
        }


        private void DisplayTileBlock(string _label, Texture _texture, SerializedProperty _sProperty, Tile _tile)
        {
            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.BeginVertical();
            GUILayout.Label(_label, alignGUILeft, GUILayout.ExpandWidth(true));
            _sProperty.objectReferenceValue = EditorGUILayout.ObjectField(_tile, typeof(Tile), true) as Tile;
            EditorGUILayout.EndVertical();
            GUILayout.Label(_texture, alignGUIRight, GUILayout.ExpandWidth(true));

            EditorGUILayout.EndHorizontal();
        }


        private void DisplayTileObjBlock(string _label, Texture _texture, SerializedProperty _sProperty, GameObject _tileObj)
        {
            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.BeginVertical();
            GUILayout.Label(_label, alignGUILeft, GUILayout.ExpandWidth(true));
            _sProperty.objectReferenceValue = EditorGUILayout.ObjectField(_tileObj, typeof(GameObject), true) as GameObject;
            EditorGUILayout.EndVertical();
            GUILayout.Label(_texture, alignGUIRight, GUILayout.ExpandWidth(true));

            EditorGUILayout.EndHorizontal();
        }


        private void LayerOffsets()
        {
            EditorGUILayout.Space(20);
            EditorGUILayout.LabelField("Layers offset", EditorStyles.boldLabel);
            EditorGUILayout.Space(5);


            _floorOffset.floatValue = EditorGUILayout.FloatField("Floor Offset", script.floorOffset);
            _wallOffset.floatValue = EditorGUILayout.FloatField("Wall Offset", script.wallOffset);
            _overlayOffset.floatValue = EditorGUILayout.FloatField("Overlay Offset", script.overlayOffset);
            _emptyOffset.floatValue = EditorGUILayout.FloatField("Empty Offset", script.emptyOffset);
        }
    }
}