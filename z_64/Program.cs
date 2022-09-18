Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

if (m>n)
for (int i = n; i <= m; i++)
    Console.Write($" {i}");
else
    for (int i = m; i <= n; i++)
        Console.Write($" {i}");