int n = 5;
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(", ", array) + "]");
//сложность алгоритма - Онотация О(1) сколько действий требуется
//O(n)
// [1,2,3,4,5] быстрая сортировка - O(n* log n)
// ((5 + 1)/2 * 5 -> O(1)) сумма всех чисел - сумма арифметической прогрессии
// n < n * log(n) +1
int sum = 0;
for (int i = 0; i < n; i++)
    sum += array[i];
Console.WriteLine(sum);
// O(n)