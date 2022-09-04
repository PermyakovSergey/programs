string text = "- Я думаю, - сказал книязь, улыбаясь, - что "
            + "ежели вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newtext = Replace(text, 'и', '1');
Console.WriteLine(newtext);
newtext = Replace(newtext, 'о', '0');
Console.WriteLine(newtext);