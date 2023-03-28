using System.Diagnostics;

bool show = true;
int n = 2000;
int max = 100;

int[] array = new int[n];

bool Check(int[] array) // unit test
{
    int size = array.Length;

    for (int i = 0; i < size - 1; i++)
    {
        if (array[i] > array[i + 1]) return false;
    }
    return true;
}

for (int i = 0; i < n; i++) array[i] = Random.Shared.Next(10);
//for (int i = 0; i < n; i++) array[i] = n-1; в обратном порядке
if (show) Console.WriteLine($"[{String.Join(',', array)}]");
int[] arr1 = new int[n];
int[] arr2 = new int[n];

Array.Copy(array, arr1, n);
Array.Copy(array, arr2, n);
//Console.WriteLine(Check(array));
if (show) Console.WriteLine($"arr1: [{String.Join(',', arr1)}]");
Stopwatch sw = new Stopwatch();
sw.Start();



for (int k = 0; k < n - 1; k++)
{
    for (int i = 0; i < n - 1 - k; i++)
    {
        if (arr1[i] > arr1[i + 1])
        {
            int temp = arr1[i];
            arr1[i] = arr1[i + 1];
            arr1[i + 1] = temp;
        }
    }
}
sw.Stop();
Console.WriteLine($"arr1 - {Check(arr1)} {sw.ElapsedMilliseconds}ms");
if (show) Console.WriteLine($"arr1: [{String.Join(',', arr1)}]");
if (show) Console.WriteLine($"arr2: [{String.Join(',', arr2)}]");
//Console.ReadLine();
sw.Reset();
sw.Start();

for (int k = 0; k < n - 1; k++)
{
    for (int i = 0; i < n - 1 ; i++)
    {
        if (arr2[i] > arr2[i + 1])
        {
            int temp = arr2[i];
            arr2[i] = arr2[i + 1];
            arr2[i + 1] = temp;
        }
    }
}
sw.Stop();

Console.WriteLine($"arr2 - {Check(arr2)} {sw.ElapsedMilliseconds}ms");

if (show) Console.WriteLine($"arr2: [{String.Join(',', arr2)}]");
//Console.WriteLine(Check(array));

//Console.WriteLine($"arr2 - {Check(arr2)}");

// int i = 12;
// i++; // O(5) i  = i +1;
// while (i < n) i++; //O(3) O(n) - 5% пренебрежение константой

//int j = 0;

// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine(array[i]);
// }
//i = 0;
//while (j < n) Console.Write(array[j++] + " ");
