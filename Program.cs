//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int ReadInt (string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32 (Console.ReadLine());
    return value;
}

bool Hollidays (int number)
{
    if (number == 6 || number == 7)
    {
        System.Console.WriteLine("да");
        return true;
    }

    System.Console.WriteLine("нет");
    return  false;
}

int num  = ReadInt("Введите цифру, обозначающую день недели >> ");
Hollidays(num);
