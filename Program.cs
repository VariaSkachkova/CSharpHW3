
Console.WriteLine ("Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("Введите пятизначное число: ");
string n = Console.ReadLine();
void Task19 (string arg)
{
    int length = arg.Length;
    if (length == 5)
    {
        if (arg[0]==arg[4] && arg[1]==arg[3])
        {
            Console.WriteLine("Это число – палиндром");
        }
        else
        {
        Console.WriteLine("Это число не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели не пятизначное число");
    }
}
Task19(n);

void Task21()
{
    Console.WriteLine("Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
    Console.WriteLine("Введите первую координату по оси Х: ");
    int x1 = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine("Введите первую координату по оси Y: ");
    int y1 = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine("Введите первую координату по оси Z: ");
    int z1 = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine("Введите вторую координату по оси Х: ");
    int x2 = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine("Введите вторую координату по оси Y: ");
    int y2 = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine("Введите вторую координату по оси Z: ");
    int z2 = Convert.ToInt32 (Console.ReadLine ());
    double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
    Console.WriteLine(result);
    
}
Task21 ();

void Task23()
{
    Console.WriteLine("Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
    Console.WriteLine("Введите целое положительное число: ");
    int num = Convert.ToInt32 (Console.ReadLine ());
    double count = 1;
    if (num > 0)
    {
        while (count <= num)
        {
            double result = Math.Pow(count, 3);
            Console.Write(result + " ");
            count ++;
        }
    }
    else 
    {
       Console.WriteLine("Вы ввели отрицательное число: "); 
    }
}
Task23();