/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/


int ReadData(string line)
{
    Console.WriteLine(line);
    int daynumber = int.Parse(Console.ReadLine()??"");
    return daynumber;
}

int dayNumber = ReadData("Введите число от 1 до 7 ");
Console.WriteLine(WorkHoliday(dayNumber));

string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Под цифрой " + a + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    return " день.";
}