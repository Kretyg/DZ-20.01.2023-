// Подсчитать сумму цифр в числе

int number = new Random().Next(1, 100000);
int sumN = 0;
Console.Write($"Сумма цифр числа {number} равна ");

while (number > 0)
{
    int n = number % 10;
    sumN = sumN + n;
    number = number / 10;
}

Console.WriteLine(sumN);
Console.WriteLine();