// Программа, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше или равна 3 символам 

string[] array;
Console.WriteLine("Введите массив строк через пробел:");
string? stroka = Console.ReadLine();
array = stroka!.Split(' ');

void ArrayLines(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"{array[i]} ");
        }
    }
}

ArrayLines(array);
