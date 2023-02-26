// See https://aka.ms/new-console-template for more information
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
}
int[] massive = new int[8];
FillArray(massive);
string result = String.Join(" ", massive);
Console.WriteLine($"[{result}]");
