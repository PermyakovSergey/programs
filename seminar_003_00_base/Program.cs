void PrintText(string text)
{
    if (string.IsNullOrEmpty(text))
    {
        Console.WriteLine("string is empty");
        return;
    }
    Console.WriteLine(text);
}
PrintText("123");