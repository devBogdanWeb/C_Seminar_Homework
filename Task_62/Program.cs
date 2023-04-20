int n = 4;
        int[,] arr = new int[n, n];
        int count = 1;

        int minRow = 0;
        int maxRow = n - 1;
        int minCol = 0;
        int maxCol = n - 1;

        while (count <= n * n)
        {
            for (int i = minCol; i <= maxCol; i++)
            {
                arr[minRow, i] = count++;
            }
            minRow++;

            for (int i = minRow; i <= maxRow; i++)
            {
                arr[i, maxCol] = count++;
            }
            maxCol--;

            for (int i = maxCol; i >= minCol; i--)
            {
                arr[maxRow, i] = count++;
            }
            maxRow--;

            for (int i = maxRow; i >= minRow; i--)
            {
                arr[i, minCol] = count++;
            }
            minCol++;
        }

        // вывод массива на консоль
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0:D2} ", arr[i, j]);
            }
            Console.WriteLine();
        }