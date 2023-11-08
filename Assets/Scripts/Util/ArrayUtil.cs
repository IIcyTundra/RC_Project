using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;

static class ArrayUtil
{
    public static R[,] Select<T, R>(this T[,] items, Func<T, R> map)
    { 
        int dim0 = items.GetLength(0);
        int dim1 = items.GetLength(1);
        var result = new R[dim0, dim1];
        for(int i = 0; i < dim0; i++)
        {
            for(int j = 0; j < dim1; j++)
            {
                result[i,j] = map(items[i,j]);
            }
        }
        return result;
    }
    //rank 1 array
    public static IEnumerable<int> IndicesWhere<T> (this T[] values, Func<T, bool> predicate)
    {
        for (int i = 0; i < values.Length; i++)
        {
            if (predicate(values[i]))
            {
                yield return i;
            }
        }
    }
    //rank 2 array
    public static IEnumerable<int[]> IndicesWhere<T>(this T[,] values, Func<T, bool> predicate)
    {
        for (int i = 0; i < values.GetLength(0); i++)
        {
            for (int j = 0; j < values.GetLength(1); j++)
            {
                if (predicate(values[i,j]))
                {
                    yield return new int[]{i, j};
                }
            }

        }
    }

    public static float[] Normalize(this float[] x, Func<float[], float> norm) {
        float result = norm(x);
        return x.Select(y => y / result).ToArray();
    }
    //TODO: test this for real
    //rank n array
    /*
    public static IEnumerable<int[]> IndecesWhere<T>(this Array values, Func<T, bool> predicate)
    {
        int[] lengths = new int[values.Rank];
        for (int i = 0; i < values.Rank; i++)
        {
            lengths[i] = values.GetLength(i);
        }
        for (int n = 0; n < values.Length; n++)
        {
            int[] i = new int[values.Rank];
            int temp = n;
            for (int j = 0; j < i.Length; j++)
            {
                i[j] = temp % lengths[j];
                temp /= lengths[j];
            }
            if (predicate((T)values.GetValue(i)))
            {
                yield return i;
            }
        }
    }
    */
}