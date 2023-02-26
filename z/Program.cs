/* Написать программу, которая из имеющегося массива строк сформирует массив из строк,
 длина которых меньше, либо равна 3 символа.*/

string[] BaseArray = new string[5] {"456", "23", "hello", "world", "yes"};
string[] SortArray = new string[BaseArray.Length];
void SortArrayWith3Sumb(string[] BaseArray, string[] SortArray)
{
    int j = 0;
    for (int i = 0; i < BaseArray.Length; i++)
    {
    if(BaseArray[i].Length <= 3)
        {
        SortArray[j] = BaseArray[i];
        j++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Исходный массив:");
PrintArray(BaseArray);
SortArrayWith3Sumb(BaseArray, SortArray);
Console.WriteLine("Отсортированный массив:");
PrintArray(SortArray);





