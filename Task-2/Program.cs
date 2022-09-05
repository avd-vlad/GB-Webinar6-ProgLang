/*----------------------------------------------------------------------------------------------------------------------
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
----------------------------------------------------------------------------------------------------------------------*/
void ShowArr(int[] arr)
{
    Console.Write("[");
    for(int i=0; i<arr.Length;i++)
        if(i==arr.Length-1)
            Console.Write($"{arr[i]} ]");
        else
            Console.Write($"{arr[i]}, ");
    Console.WriteLine();
}

int[] GenFib(int a, int b, int n)
{
    int[] x = new int[n];
    x[0] = a;
    x[1] = b;
    for(int i=2; i<n; i++)
        x[i] = x[i-2] + x[i-1];
    return x;
}

Console.Write("Введите первое число ряда: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ряда: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество чисел ряда: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowArr(GenFib(a,b,n));

