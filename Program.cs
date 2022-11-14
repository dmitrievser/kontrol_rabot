// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. ПРи решения не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительными массивами.

Console.Clear();
string[] arrayOld = new string[] { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };
string[] arrayNew = new string[arrayOld.Length];

void ArrayWithСondition(string[] arrayOld, string[] arrayNew)
{
    int count = 0;
    for (int i = 0; i < arrayOld.Length; i++)
    {
        Console.Write($"{arrayOld[i]} ");
        if (arrayOld[i].Length <= 3)
        {
            arrayNew[count] = arrayOld[i];
            count++;
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
Console.WriteLine($"Первоначальный массив:");

ArrayWithСondition(arrayOld, arrayNew);

Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Новый массив с условием:");

PrintArray(arrayNew);

Console.WriteLine();