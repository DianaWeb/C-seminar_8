/* Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. */
System.Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, 1, 9);
PrintMatrix(ourMatrix);
System.Console.WriteLine();
SwapFirstAndLastRows(ourMatrix);
PrintMatrix(ourMatrix);

void SwapFirstAndLastRows(int[,] matrix)
{
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		int temp = matrix[0, j];
		matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
		matrix[matrix.GetLength(0) - 1, j] = temp;
	}
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