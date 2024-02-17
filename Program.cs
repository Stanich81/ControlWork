Console.Clear();
// Задаем массив из строк
Console.WriteLine("Задайте количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
Console.WriteLine($"Заполните массив на {n} элементов.");
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент: ");
    array[i] = Console.ReadLine();
}


Console.WriteLine($"Выводим наш массив: ");
Console.WriteLine(string.Join("; ", array));

