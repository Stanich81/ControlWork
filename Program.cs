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
Console.WriteLine($"Выводим наш массив: [ {string.Join("; ", array)} ]");

//Вычисляем длину каждого элемента строчного массива и заносим данные в новый массив, также вычисляем количество элементов длина которых меньше или равна трех
int[] count = new int[n];
int k = 0;
for (int i = 0; i < n; i++)
{
    count[i] = array[i].Length;
    if (count[i] <=3) k++;
}
Console.WriteLine($"Длины строк введенного массива: [ {string.Join("; ", count)} ]");
Console.WriteLine($"Количество элеменов длина которых <=3 равна {k}");

