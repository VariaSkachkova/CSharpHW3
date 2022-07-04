
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
        Console.WriteLine("Введите все-таки пятизначное число");
    }
}
Task19(n);
