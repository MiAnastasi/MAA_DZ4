// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetNumArray(int size)
{
int[] result = new int[size]; // size = 2; result = [0,0]
for (int i = 0; i < result.Length; i++) // size = result.Length
    {
        //int num = Console.ReadLine();
        result[i] = Convert.ToInt32(Console.ReadLine()); // если указано одно число, то идем от 0 до этого числа
    }
return result;
}
int[] testArray = GetNumArray(8);
Console.WriteLine($"Массив: [ {String.Join(", ",testArray)} ]");