// принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;
if(b > a && b > c)
{
    max = b;
}
else if(c > a && c > b)
{
    max = c;
}
else if(a > c && a > b)
{
    max = a;
}
System.Console.WriteLine($"Максимум: {max}");