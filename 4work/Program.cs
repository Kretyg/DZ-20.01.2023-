// Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
Console.WriteLine("Четные");
while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} ^ 3 = {i*i*i}");
        i++;
    }
    else if (i % 2 == 1)
    {
        i++;
    }
}