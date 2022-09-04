// Написать программу, которая на вход получает массив данных от пользователя через запятую 
// и на выходе выдаёт массив состоящий из четных чисел
// пример:
// 1,2,3,4,5,6,7,8 => 2 4 6 8

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write(arr[arr.Length - 1]);
}

int[] ConvertStringToInt(string str)
{
    string[] strArray = str.Split(',');
    int[] arr = new int[strArray.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = int.Parse(strArray[i]);
        // Console.Write($"{arr[i]} ");
    }
    return arr;
}

int GetNumbersCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] arrayPositiveOnly(int[] arr, int length)
{
    int[] newArray = new int[length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            newArray[count] = arr[i];
            count++;
        }
    }
    return newArray;
}

Console.Write("Enter numbers separated by a comma: ");

string str = Console.ReadLine();

int[] array = ConvertStringToInt(str);
int sizeNewArray = GetNumbersCount(array);
int[] arrayPositive = arrayPositiveOnly(array, sizeNewArray);
PrintArray(arrayPositive);


