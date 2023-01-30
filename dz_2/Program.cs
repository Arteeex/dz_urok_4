Console.Clear();

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int sum = 0;
while (a > 0)
{
    sum += a % 10;
    a /= 10;
}
System.Console.WriteLine(sum);