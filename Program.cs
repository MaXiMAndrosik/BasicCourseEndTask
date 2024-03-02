/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Clear();
// ВАРИАНТ с вводом данных в массив
Console.Write("Заполните массив строками через пробел: ");
string myStringData = Console.ReadLine();
string[] myArray = myStringData.Split(" ");
Console.WriteLine($"Введенный массив: [{string.Join(" , ", myArray)}]");

// ВАРИАНТЫ заданных массивов 
// string[] myArray = new[] {"Hello", "2", "world", ":-)"};
// string[] myArray = {"1234", "1567", "-2", "computer science"};
// string[] myArray = {"Russia", "Denmark", "Kazan"};
// Console.WriteLine($"Начальный массив: [{string.Join(" , ", myArray)}]");

// Определение количества строк начального массива, длина которых меньше, либо равна 3 символам
int count = 0;
foreach (string str in myArray) {
    if (str.Length <= 3) count++;
}
// Создание нового массива необходимого размера
string[] endArray = new string[count];
// Заполнение нового массива строками, длина которых меньше, либо равна 3 символам
count = 0;
foreach (string str in myArray) {
    if (str.Length <= 3){
        endArray[count] = str;
        count++;
    }
}

Console.WriteLine($"Окончательный массив: [{string.Join(" , ", endArray)}]");