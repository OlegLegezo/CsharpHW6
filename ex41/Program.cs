// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите элементы массива через пробел: ");
int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();//пачка конвертаций из семинара, надо разобраться

Console.WriteLine(String.Join(" ", array));

int size = array.Length;
int posValue = 0;

for (int i = 0; i < size; i++)
{
if (array[i]>0) posValue++;
}
Console.WriteLine($"количество положительныых чисел: {posValue}");