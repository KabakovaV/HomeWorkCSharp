namespace Homework2;
    public static class Program
{
    public static void Main()
    {
        Console.WriteLine("введите размер массива: ");
        int size;
        size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите элемент номер {i} массива: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        int max = array[0];
        for (int i = 1; i < size; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            else continue;
        }

        int result = array[0];

        for (int i = 1; i < size; i++)
        {
            if (array[i] > result && array[i] != max)
            {
                result = array[i];
            }
            else continue;
        }

        Console.WriteLine(result);

    }
}
