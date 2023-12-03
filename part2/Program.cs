class Program{
    static void Main(string[] args){
        int[,] newArray = InitializeFilledAray2D(6,6);
        PrintAray2D(newArray);
        Array2DChangeRows(newArray);
        PrintAray2D(newArray);
    }
    static int[,] InitializeFilledAray2D(int rows, int cols){
        int[,] array = new int[rows,cols];
        for (int i = 0; i < array.GetLength(0);i++){
            for (int j = 0; j < array.GetLength(1); j++){
                array[i,j] = new Random().Next(10,100);
            }
        } 
        return array;
    }
    static void PrintAray2D(int[,] array){
        for (int i = 0; i < array.GetLength(0);i++){
            for (int j = 0; j < array.GetLength(1); j++){
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        } 
        Console.WriteLine();
    }

    static void Array2DChangeRows(int[,] array){
        int[] firstRow = GetRow(array, 0);
        int[] lastRow = GetRow(array, array.GetLength(0)-1);
        SetRow(array, firstRow, array.GetLength(0)-1);
        SetRow(array, lastRow, 0);
    }

    static int[] GetRow(int[,] array, int row){
        int[] rowArray = new int[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(1); i++){
            rowArray[i] = array[row, i];
        }
        return rowArray;
    }

      static void SetRow(int[,] array, int[] rowArray,int row){
        for (int i = 0; i < array.GetLength(1); i++){
            array[row, i] = rowArray[i];
        }
    }  
}