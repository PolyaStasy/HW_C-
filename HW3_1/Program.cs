// на вход пятизначное число number и проверяет, 
// является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, 
// в противном случае - вывести Число не пятизначное и False в следующей строке.
// Для остальных чисел вернуть True или False.

int[] New = new int[5]; 
System.Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine()); // 54678

New[0] = number/10000; // 54678 / 10000 = 5
New[1] = number/1000 % 10; 
New[2] = number/100 % 10;
New[3] = number/10 % 10;
New[4] = number % 10;

if(number >= 10000 && number <= 99999)
{
    if(New[0] == New[4] && New[1] == New[3])
    {
        System.Console.WriteLine("True");
    }
    else
    {
        System.Console.WriteLine("False");
    }
}
else{
    System.Console.WriteLine("Число введено неверно");
}