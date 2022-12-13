// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Задача решена с использованием метода изменения размера массива.
// Также решение возможно с использованием метода AddStringToArray, возвращающего массив с добавлением новой строки, который представлен ниже в комментариях.

// string[] AddStringToArray(string[] array, string add_string)
// {
//     string[] newarray = new string[array.Length + 1];
//     for(int i = 0; i < array.Length; i++) newarray[i] = array[i];
//     newarray[array.Length] = add_string;
//     return newarray;
// }


Console.Write("Введите значения строкового массива через пробел: ");
string[] array = Console.ReadLine()!.Split();
string[] result_array = { };
int k = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3 && array[i] != string.Empty)
    {
        // result_array = AddStringToArray(result_array, array[i]);
        Array.Resize(ref result_array, k + 1);
        result_array[k++] = array[i];
    }
}
Console.Write("[{0}{1}{2}]  ->  ", (array[0] == string.Empty) ? "" : "\"", String.Join("\", \"", array), (array[0] == string.Empty) ? "" : "\"");
Console.WriteLine("[{0}{1}{2}]", (result_array.Length == 0) ? "" : "\"", String.Join("\", \"", result_array), (result_array.Length == 0) ? "" : "\"");