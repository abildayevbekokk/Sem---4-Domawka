// See https://aka.ms/new-console-template for more information
int Read(string msg)
{
Console.WriteLine(msg);
int A = Convert.ToInt32(Console.ReadLine());
return A;
}

int[] FillArray(int length, int min, int max)
{
    
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);        
    }
    return array;
}

int length = Read("Введите длину массива: ");
int min = Read("Введите минимальный порог: ");
int max = Read("Введите максимальный порог: ");
int [] massive = FillArray(length, min, max);
string print = String.Join(" ", massive);
Console.WriteLine($"[{print}]");
