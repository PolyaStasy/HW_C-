// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string text)
{
    System.Console.Write(text);
    int res = Convert.ToInt32(System.Console.ReadLine());
    return res;
}

int Sum(int number)
{
    int result = 0;
    while(number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Prompt("Введите число: ");
System.Console.WriteLine(Sum(number));