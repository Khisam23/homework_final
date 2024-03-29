﻿﻿Console.Write("Введите натуральное число M: ");
string m = Console.ReadLine();

Console.Write("Введите натуральное число N: ");
string n = Console.ReadLine();

var numberM = ExceptionHandling(m);
var numberN = ExceptionHandling(n);

if (numberM.exception && numberN.exception && numberM.number >= 0 && numberN.number >= 0)
{
    if (numberM.number < numberN.number)
    {
        Console.WriteLine($"Сумма = {Summa(numberM.number, numberN.number)}");
    }
    else
    {
        Console.WriteLine($"Сумма = {Summa(numberN.number, numberM.number)}");
    }
    
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"{m}, {n} -> Некорректный ввод!");
}

int Summa(int firstNumber, int lastNumber)
{
    if (lastNumber >= firstNumber) return (lastNumber) + Summa(firstNumber, --lastNumber);
    return 0;  
}

(bool exception, int number) ExceptionHandling(string number)
{
    bool yesInt = int.TryParse(number, out int d);
    if (!yesInt)
    {
        return (false, d);
    }
    return (true, d);
}