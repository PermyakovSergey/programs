// string NumbersFor(int a, int b)
// {
//     string result = string.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// Console.WriteLine(NumbersFor(1, 5));

// string NumbersRec(int a, int b)
// {
//     if (a < b) return $"{a} " + NumbersRec(a + 1, b);
//     else return $"{a} ";
// }
// Console.WriteLine(NumbersRec(1, 5));

// int SumOfNumbers(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++)
//         result += i;
//     return result;
// }

// Console.WriteLine(SumOfNumbers(5));

// int SumRec(int n)
// {
//     if (n == 1) return 1;
//     else return n + SumRec(n - 1);
// }

// Console.WriteLine(SumRec(10));

// Вычислить a в степени n
// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// int PowerRec(int a, int n)
// {   //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
//     if (n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }

// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));

// char[] s = { 'q', 'e', 'r', 't', 'y' };
// int n = 1;
// for (int i = 0; i < s.Length; i++)
// {
//     for (int j = 0; j < s.Length; j++)
//     {
//         Console.WriteLine($"{n++,-5} {s[i]}{s[j]}");
//     }
// }

// int n = 1;
// void FindWords(string alphabet, char[] word, int lenght = 0)
// {
//     if (lenght == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[lenght] = alphabet[i];
//         FindWords(alphabet, word, lenght + 1);
//     }
// }
// FindWords("аисв", new char[5]);

// string path = "C:/programs/lesson4_001_methods";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }

// void CatalogInfo(string path, string ident = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);
//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{ident}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, ident + " ");
//     }
//     FileInfo[] files = catalog.GetFiles();
//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{ident}{files[i].Name}");
//     }
// }
// string path = "C:/Users/Пользователь/Desktop/GB";
// CatalogInfo(path);

// void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }
// Towers();

// // ((4 - 2) * (1 + 3)) / 10
// string emp = string.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3", };
// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }
// InOrderTraversal();