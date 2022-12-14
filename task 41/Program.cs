Console.Write("Введите размер массива - ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int i = 0;
int k = 0;
Console.WriteLine();
for(i = 0; i < arr.Length; i++)
{
Console.Write("Введите число в массив - ");
arr[i] = Convert.ToInt32(Console.ReadLine());
if (arr[i] > 0)
{
    
    k = k + 1;
    
}

}
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0 = {k}");
