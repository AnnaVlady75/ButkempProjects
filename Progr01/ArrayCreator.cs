/// <summary>
/// Это класс, отвечающий за создание массива
/// </summary>
public static class ArrayCreator
{
    /// <summary>
    /// Метод создания массива
    /// </summary>
    /// <param name="n">количество элементов</param>
    /// <returns>новый массив</returns>
    public static int[] Create(this int n)
    {
        return new int[n];
    }

    /// <summary>
    /// Лепит массив в строку
    /// </summary>
    /// <param name="array">массив</param>
    /// <returns>строку с представлением массива</returns>
    public static string ConvertToStringAndPrintIntoTerminal(this int[] array)
    {
        string str = $"[{String.Join(',', array)}]";
        Console.WriteLine(str);
        return str;
    }

    /// <summary>
    /// Зарлдняет массив
    /// </summary>
    /// <param name="array">массив</param>
    /// <param name="min">нижняя граница диапазона генератора случайных чисел</param>
    /// <param name="max">верхняя граница диапазона генератора случайных чисел</param>
    public static int[] Fill(this int[] array, int min = 0, int max = 10, int seed = 0)
    {
        Random random = seed == 0 ? new Random() : new Random(seed);
        return array.Select(item => random.Next(min, max)).ToArray();
    }
}
