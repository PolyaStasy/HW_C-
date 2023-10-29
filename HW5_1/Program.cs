// Напишите программу, которая подсчитывает 
// количество четных элементов в массиве целых 
// положительных трехзначных чисел и выводит результат 
// на экран.

int CountEvenElements(int[] array)
{ 
    
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
          count ++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if(i < array.Length - 1)
            System.Console.Write("\t");
    }
    Console.WriteLine();

}

int[] GenerateArray(int sizeArray, int leftRange, int rigthRange)
{
    int[] newArray = new int[sizeArray];
    Random rand = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(leftRange, rigthRange + 1);
    }
    return newArray;
}

// -----------------------------
int[] array = GenerateArray(15, 100, 999);
PrintArray(array);
System.Console.WriteLine("Четные: " + CountEvenElements(array));