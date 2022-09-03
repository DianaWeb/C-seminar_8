/* Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6

1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
В нашей исходной матрице встречаются элементы от 0 до 9 */
System.Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, 1, 9);
PrintMatrix(ourMatrix);
PrintRepeatsOfElements(ourMatrix);

void PrintRepeatsOfElements(int[,] matrix)
{
	int[] repeats = new int[10];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			repeats[matrix[i, j]]++;
		}
	}
	for (int i = 0; i < repeats.Length; i++)
	{
		if (repeats[i] > 0)
		{
			System.Console.WriteLine($"{i} встречается {repeats[i]} раз");
		}
	}
	/* int[] repeats = new int[10];
	for (int a = 0; a < repeats.Length; a++)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				if (a == matrix[i, j])
				{
					repeats[a]++;
				}
			}
		}
		if (repeats[a] > 0)
		{
			System.Console.WriteLine($"{a} встречается {repeats[a]} раз");
		}
	} */
	// System.Console.WriteLine(string.Join(", ", repeats));



	/* int count = 0;
	for (int a = 0; a < 10; a++)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				if (matrix[i, j] == a)
				{
					count++;
				}
			}
		}
		if (count > 0)
		{
			System.Console.WriteLine($"{a} встречается {count} раз");
			count = 0;
		}

	} */
}


int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
	Random rund = new Random();
	int[,] matrix = new int[rowsCount, columnsCount];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = rund.Next(leftRange, rightRange + 1);
		}
	}
	return matrix;
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			System.Console.Write(matrix[i, j] + " ");
		}
		System.Console.WriteLine();
	}
}