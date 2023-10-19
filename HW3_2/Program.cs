// расстояние между точками в 3д

internal class Program
{
    private static void Main(string[] args)
    {
        int[] pointA = new int[3];
        System.Console.WriteLine("Введите координату X точки A: ");
        pointA[0] = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Введите координату Y точки A: ");
        pointA[1] = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Введите координату Z точки A: ");
        pointA[2] = Convert.ToInt32(Console.ReadLine());

        int[] pointB = new int[3];
        System.Console.WriteLine("Введите координату X точки B: ");
        pointB[0] = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Введите координату Y точки B: ");
        pointB[1] = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Введите координату Z точки B: ");
        pointB[2] = Convert.ToInt32(Console.ReadLine());

        int resX = (int)Math.Pow(pointA[0] - pointB[0], 2); // возведение в степень
                                                            // int resX = Convert.ToInt32(Math.Pow(A[0] - B[0], 2));

        int resY = (int)Math.Pow(pointA[1] - pointB[1], 2);
        int resZ = (int)Math.Pow(pointA[2] - pointB[2], 2);

        double distance = Math.Sqrt(resX + resY + resZ); // корень

        System.Console.WriteLine(Math.Round(distance, 2)); // округление, количество знаков после запятой
    }
}