// Напишите программу, которая задаёт массив произвольной длины, заполняет произвольными элементами и выводит их на экран.
// Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];

for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(0,15);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}




