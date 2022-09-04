int Verification(string input)
{
    bool result = Int32.TryParse(input, out int number);
    if (result == false) Console.Write("wrong number");
    return number;
}
string n = Console.ReadLine();
Console.WriteLine(Verification(n));
// number = -987;

