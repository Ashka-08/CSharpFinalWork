Console.Clear();

int n = 3;
Console.WriteLine("Выберите вариант заполнения массива, 1 или 2");
Console.WriteLine("1. Ввод вручную");
Console.WriteLine("2. Сгенерированный случайным образом");
int choice = int.Parse(Console.ReadLine()!);

if (choice == 1)
{
    Console.WriteLine("Введите элементы массива через пробел: ");
    string[] Array1 = FillArray(Console.ReadLine() ?? "q w");
    string[] Array2 = CreateArray(Array1, n);
    Console.WriteLine("->");
    PrintArray(Array2);
}
else if (choice == 2)
{
    Console.WriteLine("Случайный строковый массив:");
    int size = new Random().Next(0, 5);
    string[] Array1 = new string[size];
    RandomArray(Array1, size);
    PrintArray(Array1);
    string[] Array2 = CreateArray(Array1, n);
    Console.WriteLine("->");
    PrintArray(Array2);
}

string[] FillArray(string str)
{
    char[] separators = { ' ', ',', ';' };
    string[] tempArray = str.Split(separators);
    return tempArray;
}

void RandomArray(string[] Array1, int size)
{
    Random rand = new Random();
    string AllSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
    for (int i = 0; i < size; i++)
    {
        int randElemSize = rand.Next(1,8);
        for (int j = 0; j < randElemSize; j++)
        {
            Array1[i] += AllSymbols[rand.Next(0,AllSymbols.Length)];
        }
    }
}

void PrintArray(string[] Array)
{
    int arrayLength = Array.Length;
    if (arrayLength == 0)
    {
        Console.WriteLine("[]");
        return;
    }
    Console.Write("[");
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine("]");
}

string[] CreateArray(string[] Array1, int n)
{
    int arrayLength = Array1.Length;
    int j = 0;
    for (int i = 0; i < arrayLength; i++)
    {
        if (Array1[i].Length <= n)
            j++;
    }
    string[] Array2 = new string[j];
    j = 0;
    for (int i = 0; i < arrayLength; i++)
    {
        if (Array1[i].Length <= n)
        {
            Array2[j] = Array1[i];
            j++;
        }
    }
    return Array2;
}