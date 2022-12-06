Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
for (i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}
