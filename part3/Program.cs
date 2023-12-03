class Program{
    static void Main(string[] args){
        int[,] newArray = InitializeFilledAray2D(6,6);
        PrintAray2D(newArray);
        int[] minRow = GetMinRow(newArray);
        Console.WriteLine($"Минимальная сумма: {SumRow(minRow)}");
        
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
            Console.Write($"Сумма: {SumRow(GetRow(array, i))}");
            Console.WriteLine();
        } 
        Console.WriteLine();
    }

    static int[] GetRow(int[,] array, int row){
        int[] rowArray = new int[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(1); i++){
            rowArray[i] = array[row, i];
        }
        return rowArray;
    }

    static int SumRow(int[] row){
        int summ = 0;
        for (int i = 0; i < row.Length; i++){
            summ += row[i];
        }
        return summ;
    }

    static int[] GetMinRow(int[,] array){
        int[] minRow = GetRow(array,0);
        for(int i = 1; i < array.GetLength(1); i++){
            int[] newRow = GetRow(array, i);
            if (SumRow(newRow) < SumRow(minRow)){
                minRow = newRow;
            }
        }
        return minRow;
    }
}