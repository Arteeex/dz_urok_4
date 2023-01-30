int Pow (int num, int n)
{
    int res = num;
    for(int i = 1; i<n; i++)
    {
        res *= num;
    }
    return res;
}
Console.Write("Введите число: ");
int value1 = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int value2 = int.Parse(Console.ReadLine());

int res = Pow(value1, value2);
Console.WriteLine(res);