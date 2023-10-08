//  на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;

while(i <= number)
{
    System.Console.Write(i);
    System.Console.Write("\t");
    i = i + 2;
}