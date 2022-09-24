/* Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int ReadData(string line)

{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine()??"");
    return number;
}

char SecondNumChar(string inputNumber)
{
    char[] symbols = inputNumber.ToCharArray();
    return symbols[1];
}

int SecondNumInt(int number)
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

char secondSymbol = SecondNumChar(number.ToString());
PrintData ("Введенное вами число: ", secondSymbol.ToString());


