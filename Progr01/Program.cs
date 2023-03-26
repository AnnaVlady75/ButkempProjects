using System.Diagnostics;

int[] array = 1_000_000.Create()
                .Fill(1, 10);
//array.ConvertToStringAndPrintIntoTerminal();
//Console.WriteLine(array.ConvertToString());

int m = 10_000;
Stopwatch sw = new Stopwatch();
sw.Start();
int max = array.BadGetSum(m);
sw.Stop();
Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");
sw.Reset();
sw.Start();
max = array.GoodGetSum(m);
sw.Stop();
Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");

