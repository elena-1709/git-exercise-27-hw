// Напишите функцию и запустите ее, которая
// принимает на вход число и выдаёт сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int A)
{
int sum = 0;

    for (int i = 0; A != 0; i++)
    {
        sum += A % 10;
        A /= 10;
    }

return sum; 
}

Console.Clear();
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
int result = Sum(A);
Console.WriteLine($"Сумма цифр = {result}");
