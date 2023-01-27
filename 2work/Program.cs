// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
int sumN = 0;

for (int i = 0; number > 0; i++)
{
    int n = number % 10;
    sumN = sumN + n;
    number = number / 10;
}
Console.WriteLine(sumN);