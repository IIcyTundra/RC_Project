using JetBrains.Annotations;
using System;
using System.Diagnostics.Contracts;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

class RoomMaker
{
    internal class Room
    {
        public readonly int top;
        public readonly int bottom;
        public readonly int left;
        public readonly int right;
        public readonly int size;
        public Room ch1;
        public Room ch2;

        public Room(int top, int bottom, int left, int right)
        {
            this.top = top;
            this.bottom = bottom;
            this.left = left;
            this.right = right;
            this.size = (right - left) * (top - bottom);
        }

        bool IsLeaf()
        {
            if (ch1 == null || ch2 == null)
            {
                Debug.Log("leaf!");
            }
            return (ch1 == null && ch2 == null);
        }

        public void split(int pos, bool vert)
        {
            if(!IsLeaf())
            {
                return;
            }
            if(vert)
            {
                if( pos > right || pos < left)
                {
                    throw new ArgumentOutOfRangeException();
                }
                ch2 = new Room(top, bottom, pos, right);
                ch1 = new Room(top, bottom, left, pos);
            }
            else
            {
                if( pos > top || pos < bottom)
                {
                    throw new ArgumentOutOfRangeException();
                }
                ch1 = new Room(top, pos, left, right);
                ch2 = new Room(pos, bottom, left, right);
            }
        }
    }

    public readonly Room root;
    int aproxSize;
    
    public RoomMaker(int top, int bottom, int left, int right, int aproxSize)
    {
        this.root = new(top, bottom, left, right);
        this.aproxSize = aproxSize;
    }

    public bool RandomSplit(Room room)
    {
        int width = room.right - room.left;
        int height = room.top - room.bottom;
        Debug.Log(height);
        Debug.Log(width);
        bool vert = UnityEngine.Random.Range(0, 2) == 1;
        if(room.size < aproxSize)
        {
            return false;
        }
        if (width < height)
        {
            vert = true;
        }
        if (height < width)
        {
            vert = false;
        }
        vert = !vert;
        if (vert)
        {
            int variance = width / 10;
            room.split(room.left + width / 2 + UnityEngine.Random.Range(-variance, variance+1), true);
        }
        else
        {
            int variance = height / 10;
            room.split(room.bottom + height / 2 + UnityEngine.Random.Range(-variance, variance+1), false);
        }
        return true;
    }

    public Room ChooseRandom()
    {
        Room curr = root;
        while (RandomSplit(curr))
        {
            bool rand = UnityEngine.Random.Range(0, 2) == 1;
            if (rand)
            {
                Debug.Log("Yes!");
            } else
            {
                Debug.Log("No!");
            }
            curr = rand ? curr.ch1 : curr.ch2;
        }
        return curr;
    }

    public Room[] ChooseMany(int num, int maxTries)
    {
        int sum = 0;
        Room[] rooms = new Room[num];
        for(int i = 0; i < maxTries && sum < num; i++)
        {
            Room next = ChooseRandom();
            if (!rooms.Contains(next))
            {
                rooms[sum++] = next;
            }
        }
        Debug.Log("Rooms:");
        foreach(Room room in rooms)
        {
            Debug.Log($"l:{room.left}r:{room.right}t:{room.top}b:{room.bottom}");
        }
        return rooms;
    }

    public bool[,] GetMap(Room[] rooms, int borderSize)
    {
        bool[,] temp = new bool[root.right - root.left + 1, root.top - root.bottom + 1];
        foreach(Room room in rooms)
        {
            for(int i = room.left + borderSize; i < room.right - borderSize + 1; i++)
            {
                for(int j = room.bottom + borderSize; j < room.top - borderSize + 1;  j++)
                {
                    temp[i,j] = true;
                }
            }
        }
        return temp;
    }
}