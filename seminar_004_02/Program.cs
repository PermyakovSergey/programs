Console.Write("Введите цифру 8: ");
int number = int.Parse(Console.ReadLine());

void RandomMassive(int number)
{
    int[] massive = new int[number];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(1, 10);
        Console.Write(massive[i] + " ");
    }
    
}
