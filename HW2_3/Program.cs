// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 1 && number <= 7)
{
    if(number == 6 || number == 7)
    {
        System.Console.WriteLine("Yes");
    }
    else
    {
        System.Console.WriteLine("No");
    }
}
else
{
    System.Console.WriteLine("Неверно введен день недели");
}