/*----------------------------------------------------------------------------------------------------------------------
Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
----------------------------------------------------------------------------------------------------------------------*/

int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] newArr=new int[size];

    for(int i=0; i<size; i++)
        newArr[i]= new Random().Next(minVal,maxVal+1);

    return newArr;
}

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


int[] ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length -1 ; i<j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];       
        array[j] = temp;
    }
    return array;
}

int[] newArray = CreateRandomArray(8, 10, 99);

ShowArr(newArray);
ShowArr(ReverseArray(newArray));
