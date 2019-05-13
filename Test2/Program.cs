using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'getElements' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY arr
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static List<int> getElements(List<int> arr, List<List<int>> queries)
    {
        int sizeArr = arr.Count;
        int rows = (sizeArr - 1) / arr[0];
        int columns = arr[0];
        int[,] matrix = new int[rows, columns];
        int count = 1;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = arr.ElementAt(count++);
            }
        }

        int x, y;
        List<int> answer = new List<int> { };
        int queriesQty = queries.Count;
        for (int i = 0; i < queriesQty; i++)
        {
            x = queries[i][0] - 1;
            y = queries[i][1] - 1;
            answer.Add(matrix[x, y]);
        }

        return answer;
    }

}
