/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


int ReadData(string line)

{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine()??"");
    return number;
}

char ThirdNumChar(string inputNumber)
{
    char[] symbols = inputNumber.ToCharArray();
    return symbols[2];
}

int ThirdNumInt(int number)
{
    int lenNum = (int)Math.Log10(number)-1;
    int outNumber = (int)(number/Math.Pow(10,lenNum-2))%10;
    return 0;
}
void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

int number = ReadData("Введите число: ");
if (number < 100)
{
    PrintData("Третьего числа нет", "");
}
else
{
    char thirdSymbol = ThirdNumChar(number.ToString());
    PrintData ("Введенное вами число: ", thirdSymbol.ToString());
}