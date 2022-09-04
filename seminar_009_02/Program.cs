// Написать программу, которая на вход получает массив данных от пользователя 
// через запятую и на выходе выдаёт массив состоящий из четных чисел

// Уточните условие

// пример:
// 1,2,3,4,5,6,7,8 => 2 4 6 8

// Разбить строку на составные части
// превратить набор строк в набор чисел
// сделать выборку по условию
// подготовить данные для вывода


#region 


int IndexOf(string s, char c)
{
  for (int i = 0; i < s.Length; i++)
  {
    if (s[i] == c) return i;
  }
  return -1;
}

string[] Split(string str, char sep)
{
  string t = str + $"{sep}";
  string[] temp = new string[str.Length];
  int count = 0;
  while (t != string.Empty)
  {
    int pos = IndexOf(t, sep);
    temp[count] = t.Substring(0, pos);
    count++;
    t = t.Substring(pos + 1);
  }

  string[] el = new string[count];
  for (int i = 0; i < count; i++)
  {
    el[i] = temp[i];
  }
  return temp;
}

int[] Convert(string[] input)
{
  int size = 0;
  for (int i = 0; i < input.Length; i++)
  {
    if (!String.IsNullOrEmpty(input[i])) size++;
  }

  int[] numbers = new int[size];
  for (int i = 0; i < size; i++)
  {
    numbers[i] = int.Parse(input[i]);
  }
  return numbers;
}

int[] Where(int[] input)
{
  int size = 0;
  int length = input.Length;
  for (int i = 0; i < length; i++)
  {
    if (input[i] % 2 == 0) size++;
  }
  int[] data = new int[size];
  int index = 0;
  for (int i = 0; i < length; i++)
  {
    if (input[i] % 2 == 0)
    {
      data[index] = input[i];
      index++;
    }
  }
  return data;
}

string Join(int[] input, string sep)
{
  int size = input.Length;
  string result = String.Empty;
  if (size == 0) return result;

  for (int i = 0; i < size - 1; i++)
  {
    result += $"{input[i]}{sep}";
  }
  result += $"{input[size - 1]} ";
  return result;
}

string inp = "123,222,33312,414,5,12312";

#region 

// string[] input = Split(inp, ',');
// int[] conv = Convert(input);
// int[] data = Where(conv);
// System.Console.WriteLine(Join(data, " _ "));

#endregion
#region 
// Console.WriteLine(
// $"Итог {Join(Where(Convert(Split(inp, ','))), " ")}"
// );

#endregion


#region 
var res = inp.Split(new char[] { ',', ' ' },
                       StringSplitOptions.RemoveEmptyEntries)
                       .Select(el => int.Parse(el))
                       .Where(el => el % 2 == 0);
Console.WriteLine($"Итог {String.Join(' ', res)}");

#endregion

#endregion