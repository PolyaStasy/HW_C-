// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 326791123 -> 6

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while(number > 999)
{
    number = number / 10;
}

if(number > 99 && number < 1000)
{
    System.Console.WriteLine(number % 100 % 10);
}
else{
    System.Console.WriteLine("третьей цифры нет");
}