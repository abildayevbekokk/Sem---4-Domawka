// See https://aka.ms/new-console-template for more information
#region factorial
int Factorial(int a)
{
    int factorial = 1;
    for (int i = 1; i <= a; i++)
    {
        factorial *= i;
    }
    return factorial;
}
#endregion
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение = {Factorial(N)}");
