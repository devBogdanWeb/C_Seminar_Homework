int[,] arr = { { 4, 2, 6 }, { 1, 5, 3 }, { 9, 8, 7 } };

for (int i = 0; i < arr.GetLength(0); i++) //проходим по строкам массива
{
    //создаем временный массив для сортировки
    int[] tempArr = new int[arr.GetLength(1)];

    //копируем элементы текущей строки во временный массив
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        tempArr[j] = arr[i, j];
    }

    //сортируем элементы временного массива по убыванию
    Array.Sort(tempArr);
    Array.Reverse(tempArr);

    //копируем элементы отсортированного временного массива обратно в исходный массив
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = tempArr[j];
    }
}

//выводим отсортированный массив
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}