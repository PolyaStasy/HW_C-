// На вход принимает два числа, а потом показывает, какое больше, а какое меньше
// a = 5; b = 7 -> Первое число 5 меньше чем второе число 7
// a = 2; b = 2 -> Введенные числа равны 2
// a = -3; b = -9 -> Первое число -3 больше чем второе число -9

System.Console.WriteLine("Введите первое число: ");
int a1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int a2 = Convert.ToInt32(Console.ReadLine());

if(a1 < a2)
{
    System.Console.WriteLine($"Первое число {a1} меньше, чем второе {a2}");
}
else if(a1 == a2)
{
    System.Console.WriteLine($"Введеные числа равны {a1}");
}
else if(a1 > a2)
{
    System.Console.WriteLine($"Первое число {a1} больше, чем второе {a2}");
}