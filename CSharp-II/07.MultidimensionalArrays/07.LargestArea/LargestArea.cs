using System;
using System.Collections.Generic;

class Element
{
    public int value { get; set; }
    public int row { get; set; }
    public int col { get; set; }
}
class LargestArea
{
    static int GetLeft(int[,] matrix, int currentRow, int currentCol)
    {
        if (currentCol - 1 >= 0)
        {
            return matrix[currentRow, currentCol - 1];
        }
        else
        {
            return 0;
        }
    }
    static int GetRight(int[,] matrix, int currentRow, int currentCol)
    {
        if (currentCol + 1 < matrix.GetLength(1))
        {
            return matrix[currentRow, currentCol + 1];
        }
        else
        {
            return 0;
        }
    }
    static int GetUpper(int[,] matrix, int currentRow, int currentCol)
    {
        if (currentRow - 1 >= 0)
        {
            return matrix[currentRow - 1, currentCol];
        }
        else
        {
            return 0;
        }
    }
    static int GetDown(int[,] matrix, int currentRow, int currentCol)
    {
        if (currentRow + 1 < matrix.GetLength(0))
        {
            return matrix[currentRow + 1, currentCol];
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        int[,] matrix = 
        { 
            { 1, 3, 2, 2, 2, 4 }, 
            { 3, 3, 3, 2, 4, 4 }, 
            { 4, 3, 1, 2, 3, 3 }, 
            { 4, 3, 1, 3, 3, 1 }, 
            { 4, 3, 3, 3, 1, 1 } 
        };
        int maxSum = 0;
        int currentSum = 0;
        int currentElement = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
		{
			 for (int col = 0; col < matrix.GetLength(1); col++)
			{
                 currentElement = matrix[row, col];
                 if (currentElement != 0)
                 {
                     currentSum = 0;
                     Queue<Element> que = new Queue<Element>();
                     Element newElement = new Element();
                     newElement.value = matrix[row, col];
                     newElement.row = row;
                     newElement.col = col;
                     matrix[row, col] = 0;
                     que.Enqueue(newElement);
                     while (que.Count > 0)
                     {
                         Element current = que.Dequeue();
                         Element left = new Element();
                         left.value = GetLeft(matrix, current.row, current.col);
                         if (left.value == current.value)
                         {
                             left.row = current.row;
                             left.col = current.col - 1;
                             matrix[left.row, left.col] = 0;
                             que.Enqueue(left);
                             currentSum++;
                         }
                         Element right = new Element();
                         right.value = GetRight(matrix, current.row, current.col);
                         if (right.value == current.value)
                         {
                             right.row = current.row;
                             right.col = current.col + 1;
                             matrix[right.row, right.col] = 0;
                             que.Enqueue(right);
                             currentSum++;
                         }
                         Element upper = new Element();
                         upper.value = GetUpper(matrix, current.row, current.col);
                         if (upper.value == current.value)
                         {
                             upper.row = current.row - 1;
                             upper.col = current.col;
                             matrix[upper.row, upper.col] = 0;
                             que.Enqueue(upper);
                             currentSum++;
                         }
                         Element down = new Element();
                         down.value = GetDown(matrix, current.row, current.col);
                         if (down.value == current.value)
                         {
                             down.row = current.row + 1;
                             down.col = current.col;
                             matrix[down.row, down.col] = 0;
                             que.Enqueue(down);
                             currentSum++;
                         }
                     }
                     if (maxSum < currentSum)
                     {
                         maxSum = currentSum;
                     }
                 }
			}
		}
        Console.WriteLine(maxSum);
    }
}

