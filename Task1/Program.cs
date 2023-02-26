// See https://aka.ms/new-console-template for more information
int Sum(int a)
{
    int sum = 0;
    for (int i = 0; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}
int sum = Convert.ToInt32(Console.ReadLine());
int result = Sum(sum);
Console.WriteLine(result);