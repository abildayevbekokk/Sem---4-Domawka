// See https://aka.ms/new-console-template for more information
int Read(string msg)
{
Console.WriteLine(msg);
int numb = Convert.ToInt32(Console.ReadLine());
return numb;
}


int SumNumber(int numb)
{
    int result = 0;
    while (numb>0)
    {
        result += numb%10;
        numb /= 10;
    }
    return result;
}
int number = Read("Введите число");
Console.WriteLine(SumNumber(number));
