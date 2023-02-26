// See https://aka.ms/new-console-template for more information

int CountNumber(string a)
{
    int count = a.Length;
    return count;

}
Console.WriteLine("Введите число: ");
string a = Console.ReadLine();

Console.WriteLine($"Количество цифр = {CountNumber(a)}");