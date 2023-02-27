// See https://aka.ms/new-console-template for more information
int Read(string msg)
{
Console.WriteLine(msg);
int A = Convert.ToInt32(Console.ReadLine());
return A;
}
int A = Read("Введите первое число: ");
int B = Read("Введите первое число: ");

int MathPower(int x, int y)
{
    int result = 1;

    if (y<0)
    {
        Console.WriteLine("Пока без отрицательных");
        return 404;
    }
    else
    {


    for (int i = 0; i < y; i++)
    {
        result *= x;
    }
    }
    return result;
    

}

Console.WriteLine(MathPower(A, B));


