// x = (b2 - b1) / (k1 - k2);
// y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

string str = "1 2 3 4 5 6";
string[] strArray = str.Split(' ');
int[] array = new int[strArray.Length];
for (int i = 0; i < strArray.Length; i++)
{
    array[i] = int.Parse(strArray[i]);
}

