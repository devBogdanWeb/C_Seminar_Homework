int[,] arr = new int[3,4] {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };
        int minSumRow = 0;
        int minSum = int.MaxValue;
        for (int i = 0; i < arr.GetLength(0); i++) {
            int rowSum = 0;
            for (int j = 0; j < arr.GetLength(1); j++) {
                rowSum += arr[i,j];
            }
            if (rowSum < minSum) {
                minSum = rowSum;
                minSumRow = i;
            }
        }
        Console.WriteLine($"Строка с наименьшей суммой: {minSumRow}");