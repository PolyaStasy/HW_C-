// Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную 
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string text)
{
    System.Console.Write(text);
    int res = Convert.ToInt32(System.Console.ReadLine());
    return res;
}

int Power(int powerBase, int exponent)
{
    int power = 1;
    for(int i =0; i < exponent; i++)
    {
        power *=powerBase;
    }
    return power;    
}

bool Valid(int exponent)
{
    if(exponent < 0)
    {
        System.Console.WriteLine("Показатель не должен быт меньше 0");
        return false;
    }
    return true;
}

int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Введите показатель: ");
if (Valid(exponent))
{
    System.Console.WriteLine(Power(powerBase, exponent));
}