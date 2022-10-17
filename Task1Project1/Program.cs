// Задача: Написать программу, 
// которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array1;
Console.WriteLine("Введите массив из строк через запятую: ");
string fromUser = Console.ReadLine();
array1 = fromUser.Split(new char[]{' ', ','},
StringSplitOptions.RemoveEmptyEntries);
string[] array2 = new string[array1.Length];

FillNewMassiv(array1, array2);
PrintNewMassiv(array2);

void FillNewMassiv(string[] array1, string[] array2)

{
    int count = 0;    
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
    Array.Resize(ref array2, count);
}

void PrintNewMassiv(string[] NewMassiv)
{
Console.WriteLine("Новый массив из строк длиной <= 3 символа: ");
    for (int i = 0; i < NewMassiv.Length; i++)
    {
        Console.Write($"{NewMassiv[i]} ");
    }
    
}
