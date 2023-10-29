// Напишите программу, которая находит сумму 
// элементов с нечетными индексами в одномерном 
// массиве целых чисел и выводит результат на экран.


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

int SumOddElements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
           sum = sum + array[i];
        }
    }
    return sum;
}

// ----------------
int[] array = GenerateArray(5, 10, 20);
PrintArray(array);
System.Console.WriteLine("Sum: " + SumOddElements(array));
