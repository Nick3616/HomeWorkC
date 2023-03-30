Console.Write("Введите числа: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int sum = 0;
foreach (int element in size)
{
    if (element > 0)
        sum += 1;
}
Console.Write(sum);