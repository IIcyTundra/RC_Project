using System.Linq;
using UnityEngine;

internal class Walker
{
    public bool[,] map;
    private int x;
    private int y;
    WeightedNumberGenerator generator;
    public Walker(int sizex, int sizey, WeightedNumberGenerator generator)
    {
        this.map = new bool[sizex, sizey];
        this.generator = generator;
    }

    public Walker(int size, WeightedNumberGenerator generator) : this(size, size, generator) { }

    public Walker(int size) : this(size, size,
        new BasicNumberGenerator(
            new ConstantWeightGen(
                new float[] { 1.0f, 1.0f, 1.0f, 1.0f },
                (x) => x.Select(y => y / x.Length).ToArray()),
                1,
                4)) { }
    //NOTE: cross can cause step to roll over
    private void Step(bool cross)
    {
        map[x, y] = true;
        if (cross)
        {
            map[(x + map.GetLength(0) + 1) % map.GetLength(0), y] = true; //x+1
            map[x, (y + map.GetLength(1) + 1) % map.GetLength(1)] = true; //y+1
            map[(x + map.GetLength(0) - 1) % map.GetLength(0), y] = true; //x-1
            map[x, (y + map.GetLength(1) - 1) % map.GetLength(1)] = true; //y-1
        }
        switch (generator.Generate())
        {
            case 1:
                ++x;
                break;
            case 2:
                ++y;
                break;
            case 3:
                --x;
                break;
            case 4:
                --y;
                break;
        }
    }
    private int CountedStep(bool cross)
    {
        int temp = 0;
        temp += CountedMark(x, y);
        if (cross)
        {
            temp += CountedMark(x + 1, y);
            temp += CountedMark(x, y + 1);
            temp += CountedMark(x - 1, y);
            temp += CountedMark(x, y - 1);

        }
        switch (generator.Generate())
        {
            case 1:
                ++x;
                break;
            case 2:
                ++y;
                break;
            case 3:
                --x;
                break;
            case 4:
                --y;
                break;
        }
        return temp;
    }
    private int CountedMark(int x, int y)
    {
        if (map[(x + map.GetLength(0)) % map.GetLength(0), (y + map.GetLength(1)) % map.GetLength(1)] == false)
        {
            map[(x + map.GetLength(0)) % map.GetLength(0), (y + map.GetLength(1)) % map.GetLength(1)] = true;
            return 1;
        }
        return 0;
    }
    public void ManyWalk(int startx, int starty, int dist, int num = 1, int after = 0, bool cross = true)
    {
        for (int i = 0; i < num; i++)
        {
            x = startx;
            y = starty;
            for (int j = 0; j < dist && (x < map.GetLength(0) && x > 0) && (y < map.GetLength(1) && y > 0); j++)
            {
                if (j == after) {
                    startx = x;
                    starty = y;
                }
                Step(cross);
            }
        }
    }

    //NOTE: this function itterates through the ENTIRE MAP num times!!!
    public void RandomWalk(int startx, int starty, int dist, int num = 1, bool cross = true)
    {
        map[startx, starty] = true;
        for (int i = 0; i < num; i++)
        {
            int[][] possibleStarts = map.IndicesWhere(x => x).ToArray();
            int[] nextStart = possibleStarts[UnityEngine.Random.Range(0, possibleStarts.Length)];
            x = nextStart[0];
            y = nextStart[1];
            for (int j = 0; j < dist && (x < map.GetLength(0) && x > 0) && (y < map.GetLength(1) && y > 0); j++)
            {
                Step(cross);
            }
        }
    }

    public void ManyWalkFill(int startx, int starty, int dist, int fill, int after = 0, bool cross = true)
    {
        int sum = 0;
        while (sum < fill)
        {
            x = startx;
            y = starty;
            for (int j = 0; j < dist && (x < map.GetLength(0) && x > 0) && (y < map.GetLength(1) && y > 0); j++)
            {
                if (j == after)
                {
                    startx = x;
                    starty = y;
                }
                sum += CountedStep(cross);
            }
        }
    }

    public void RandomWalkFill(int startx, int starty, int dist, int fill, bool cross = true)
    {
        int sum = 1;
        map[startx, starty] = true;
        while (sum < fill)
        {
            int[][] possibleStarts = map.IndicesWhere(x => x).ToArray();
            int[] nextStart = possibleStarts[UnityEngine.Random.Range(0, possibleStarts.Length)];

            x = nextStart[0];
            y = nextStart[1];
            Debug.Log($"{x}, {y}");
            for (int j = 0; j < dist && (x < map.GetLength(0) && x > 0) && (y < map.GetLength(1) && y > 0); j++)
            {
                Debug.Log($"{x}, {y}");
                sum += CountedStep(cross);
            }
        }
    }
}
