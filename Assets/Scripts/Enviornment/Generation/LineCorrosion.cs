
using System.Collections;
using UnityEditor.Search;
using UnityEngine;

internal class LineCorrosion
{
    public bool[,] map;
    int x1;
    int y1;
    int x2;
    int y2;

    public LineCorrosion(int size)
    {
        this.map = new bool[size,size];
    }

    public void generate()
    {
        //FIXME: make this actually do the right thing once I know the lines are right
        x1 = 0; y1 = 0;
        x2 = 10; y2 = 20;
       
        // we're assuming that m < 1 here, and that p1 is to the left of p2 i'll do the transformations to make it general later
        if (x1 > x2) {
            (x1, x2) = (x2, x1);
            (y1, y2) = (y2, y1);
        }
        float m = (y1 - y2) / (float)(x1 - x2);
        float e = 0;
        int curx = x1;
        int cury = y1;
        map[x2, y2] = true;
        while (curx != x2)
        { 
        
        }
        if (m > 0)
        {
            if (m < 1f)
            {
                //standard algorithm
                while (curx != x2)
                {
                    map[curx, cury] = true;
                    curx++;
                    e += m;
                    if (e > 0.5)
                    {
                        cury++;
                        e -= 1;
                    }
                }
                return;
            }
            else
            {
                //if m > 1 do a reflection around x = y
                Debug.Log("reflectoin!");
                m = 1 / m;
                while (cury != y2)
                {
                    map[curx,cury] = true;
                    cury++;
                    e += m;
                    if(e > 0.5)
                    {
                        curx++;
                        e -= 1;
                    }
                }
                return;
            }
        }
        else
        {
            if (m > -1)
            {
                while (curx != x2)
                {
                    map[curx, cury] = true;
                    curx++;
                    e -= m;
                    if (e > 0.5)
                    {
                        cury--;
                        e -= 1;
                    }
                }
                return;
            }
            else
            {
                m = 1 / m;
                while (cury != y2)
                {
                    map[curx, cury] = true;
                    cury--;
                    e -= m;
                    if (e > 0.5)
                    {
                        curx++;
                        e -= 1;
                    }
                }
                return;
            }

        }
    }
}