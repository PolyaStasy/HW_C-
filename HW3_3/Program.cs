// принимает Н и выдает таблицу кубов чисел от 1 до Н

System.Console.WriteLine("Введите число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

for(int i = 1; i<=N; i++)
    System.Console.Write(Math.Pow(i, 3) + " ");

// int i = 1;

// while(i <= N)
// {
//     System.Console.Write(Math.Pow(i, 2) + " ");
//     i ++;
// }