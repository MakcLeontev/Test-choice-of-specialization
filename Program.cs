internal class GeekBrains
{
    //задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
    //длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
    //либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
    //коллекциями лучше обойтись исключительно массивами. 
    private static void Main(string[] args)
    {
        Console.Write("Введите количество элементов в массиве: ");
        int size = Convert.ToInt32(Console.ReadLine());
        string[] firstArray = new string[size];
        FillArrayConsole(firstArray);
        PrintArray(SortArray(firstArray));

    }
    public static void FillArrayConsole(string?[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Введите {i + 1} - й элемент:");
            array[i] = Console.ReadLine();

        }
    }
    public static string[] SortArray(string[] firstArray)
    {
        int count = 0;
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i].Length <= 3)
            {
                count++;
            }
        }
        string[] secondArray = new string[count];
        int secondArrayPosition = 0;
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i].Length <= 3)
            {
                secondArray[secondArrayPosition] = firstArray[i];
                secondArrayPosition++;
            }
        }
        return secondArray;

    }
    public static void PrintArray(string[] array)
    {
        Console.WriteLine("Итоговый массив");
        Console.WriteLine("[" + string.Join(",", array) + "]");
    }

}