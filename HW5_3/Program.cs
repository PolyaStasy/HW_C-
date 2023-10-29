void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if(i < array.Length - 1)
            System.Console.Write("\t");
    }
    Console.WriteLine();

}

double[] GenerateArray(int sizeArray, int leftRange, int rigthRange)
{
    double[] newArray = new double[sizeArray];
    Random rand = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(leftRange, rigthRange + 1);
    }
    return newArray;
}

double FindMax(double[] array)
    {     // Введите свое решение ниже
      double count = array[0];
      for(int i = 0; i < array.Length; i ++)
      {
        if(array[i] > count)
          count = array[i];
      }
      return count;
    }

double FindMin(double[] array)
    {     // Введите свое решение ниже
        double count = array[0];
      for(int i = 0; i < array.Length; i ++)
      {
        if(array[i] < count)
          count = array[i];
      }
      return count;

    }

double CalcDifferenceBetweenMaxMin(double[] array)
    {// Введите свое решение ниже
      double max = FindMax(array);
      double min = FindMin(array);
      double res = max - min;
      return res;
    }

// -----------------------
double[] array = GenerateArray(5, 10, 20);
PrintArray(array);
System.Console.WriteLine(CalcDifferenceBetweenMaxMin(array));