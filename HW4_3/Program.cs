// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] arrayToFill)
{
    Random rand = new Random();
    for(int i = 0; i < arrayToFill.Length; i++)
    {
        arrayToFill[i] = rand.Next(100);
    }
}

void PrintArray(int[] arrayForPrint)
{
    for( int i = 0; i < arrayForPrint.Length; i ++)
{
    System.Console.Write(arrayForPrint[i] + "  ");
}
}

// -----------

int[] array = new int[8];
FillArray(array);
PrintArray(array);