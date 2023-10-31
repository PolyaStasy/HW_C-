//  Напишите программу, которая найдёт точку пересечения
//   двух прямых, заданных уравнениями y = k1 * x + b1, 
//   y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
//   пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[] Dot(double[] array) 
{
    double[] newArray = new double[2];
    double x = (- array[0] + array[2]) / (array[1] - array[3]);
    // b1 - 0; k1 = 1; b2 - 2; k2 -3
    double y = array[1] * x + array[0];
    newArray[0] = x;
    newArray[1] = y;
    return newArray;
}

void PrintArray(double[] array)
{
      System.Console.Write($"({array[0]}, {array[1]})");
}

// ----------
Console.WriteLine("Введите значения уравнения: ");
double[] array = Array.ConvertAll(Console.ReadLine()!.Split(), double.Parse);

PrintArray(Dot(array));