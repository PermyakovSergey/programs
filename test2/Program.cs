
int CountOfStrings(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            count++;
    }
    return count;
}

string[] names = { "tom", "bend", "anna", "maxim" };
int size = CountOfStrings(names);
string[] result = new string[size];
for (int i = 0; i < result.Length; i++)
{
    for (int j = 0; j < names.Length; j++)
    {
        if (names[j].Length <= 3)
        result[i] = names[j];
        i ++;
    }
}
for (int i = 0; i < result.Length - 1; i++)
{
    Console.Write($"{result[i]}, ");
}
Console.Write(result[size -1]);