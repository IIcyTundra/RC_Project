using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;
using static RoomMaker;

public class LevelGenerator
{
    private Tilemap tilemap;
    private Tile[,] tiles;
    private Tile floor;
    private Tile wall;


    public LevelGenerator(Tile floor, Tile wall, Tilemap tilemap, int sizex, int sizey, int level = 1)
    {
        this.wall = wall;
        this.floor = floor;
        this.tilemap = tilemap;
        tiles = new Tile[sizex, sizey];
    }
    public LevelGenerator(Tile floor, Tile wall, Tilemap tilemap, int size, int level = 1) : this(floor, wall, tilemap, size, size, level) { }

    

    public void generate()
    {
        //Walker walker = new( tiles.GetLength(0)/*, new BasicNumberGenerator(new FixedSameWeightGen(1, 0.05f, 4, x => x.Normalize(y => y.Sum())), 1, 4)*/);
        //walker.RandomWalkFill(tiles.GetLength(0) / 2, tiles.GetLength(1) / 2, 1000, 2000, true);
        //LineCorrosion corrosion = new(tiles.GetLength(0));
        //corrosion.generate();
        //tiles = walker.map.Select(x => x ? floor : wall);
        RoomMaker roomMaker = new(tiles.GetLength(1), 0, 0, tiles.GetLength(0), 500);
        Room room = roomMaker.ChooseRandom();
        roomMaker.ChooseMany(10, 5000);
        Debug.Log($"l:{room.left}r:{room.right}t:{room.top}b:{room.bottom}");
        //tiles = roomMaker.GetMap(rooms, 1).Select(x => x ? floor : wall);
        for (int i = 0; i < tiles.GetLength(0); i++)
        { 
            for(int j = 0; j < tiles.GetLength(1); j++)
            {
                tilemap.SetTile(new Vector3Int(i,j), tiles[i,j]);
            }
        }
    }
}
