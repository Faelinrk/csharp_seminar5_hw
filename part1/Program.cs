class Program{
    static void Main(string[] args){
        int[,] newArray = InitializeFilledAray2D(25,25);
        Console.WriteLine(GetArrayElement2D(newArray, 50, 50));
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
    static int GetArrayElement2D(int[,] array, int row, int col){
        if (row >= array.GetLength(0) || col >= array.GetLength(1)){
            Console.WriteLine("Такого элемента нет");
            return 0;
        }
        return array[row,col];
    }
}