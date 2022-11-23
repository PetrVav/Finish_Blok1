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

string[] array1; // Первый массив вводим с клавиатуры и разбиваем, используя метод Split
Console.WriteLine("Введите массив из строк через запятую: ");
string fromUser = Console.ReadLine();
array1 = fromUser.Split(new char[]{' ', ','},
StringSplitOptions.RemoveEmptyEntries);
string[] array2 = new string[array1.Length]; //создал 2ой пустой массив, с длиной, равной длине первого массива.

FillNewMassiv(array1, ref array2); // при вызове метода тоже ref перед переменной
PrintNewMassiv(array2);

void FillNewMassiv(string[] array1, ref string[] array2) //передаем array2 в метод по ссылке ref
                                                    // (без ref в конце нового массива останутся пустые элементы)


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
    Array.Resize(ref array2, count); // изменяем размер массива, чтобы  в конце массива не было пустых элементов
   
}

void PrintNewMassiv(string[] NewMassiv)
{
Console.WriteLine("Новый массив из строк длиной <= 3 символа: ");
    for (int i = 0; i < NewMassiv.Length; i++)
    {
        Console.Write($"{NewMassiv[i]}, ");
    }
    
}

// Комментарий преподавателя:
// Здравствуйте, Пётр!
// Отлично! Здорово, что подумали об изменении размера массива, иначе бы решение не соответствовала бы условиям задачи.

// Успехов!