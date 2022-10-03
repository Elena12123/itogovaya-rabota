string[] array = new string[] {"1234", "1567", "-2", "cat", "hello"};
string[] array2 = new string[array.Length];
void FindNum(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        
    }
    Console.Write("]");
    Console.WriteLine("");
}
FindNum (array, array2);
PrintArray(array);
Console.WriteLine("Массив до изменения");
PrintArray(array2);
Console.WriteLine("Массив после изменения");
