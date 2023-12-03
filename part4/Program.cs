class Program
{
    static void Main(string[] args)
    {
        int[,] newArray = InitializeFilledAray2D(6, 25);
        PrintAray2D(newArray);
        int[,] resultArray = RemoveMinRowCol(newArray);
        PrintAray2D(resultArray);

    }
    static int[,] InitializeFilledAray2D(int rows, int cols)
    {
        int[,] array = new int[rows, cols];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(10, 100);
            }
        }
        return array;
    }
    static void PrintAray2D(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static int[] GetRow(int[,] array, int row)
    {
        int[] rowArray = new int[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(1); i++)
        {
            rowArray[i] = array[row, i];
        }
        return rowArray;
    }

    static int SumRow(int[] row)
    {
        int summ = 0;
        for (int i = 0; i < row.Length; i++)
        {
            summ += row[i];
        }
        return summ;
    }

    static int[] GetMinElementPosition(int[,] array)
    {
        int[] minElementPosition = new int[2];
        int minElement = array[0, 0];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minElementPosition = new int[] {i, j};
                }
            }
        }
        Console.WriteLine($"Позиция минимального элемента: {minElementPosition[0]}, {minElementPosition[1]}");
        return minElementPosition;
    }
    static int[,] RemoveMinRowCol(int[,] array)
    {
        int[] minElementPosition = GetMinElementPosition(array);
        int[,] resultArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
        for (int i = 0, resi = 0; i < array.GetLength(0); i++)
        {
            if (i != minElementPosition[0])
            {
                for (int j = 0, resj = 0; j < array.GetLength(1); j++)
                {
                    if (j != minElementPosition[1])
                    {
                        resultArray[resi, resj] = array[i, j];
                        resj++;
                    }
                }
                resi++;
            }
        }
        return resultArray;
    }

}