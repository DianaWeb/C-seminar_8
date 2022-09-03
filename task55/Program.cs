/* Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя. */
System.Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, 1, 9);
PrintMatrix(ourMatrix);
System.Console.WriteLine();
int[,] tMatrix = GetTMatrix(ourMatrix);
PrintMatrix(tMatrix);

int[,] GetTMatrix(int[,] matrix)
{
	int[,] tMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			tMatrix[i, j] = matrix[j, i]; // t это транс матрица
		}
	}
	return tMatrix;
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