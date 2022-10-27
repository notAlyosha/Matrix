//Че пацаны, матрицы?)
using Matrixes;
class Program
{
	public static void Main()
	{
		int[,] arr1 = {
			{3, 3},
			{2, 3},
			{3, 3},
		};

		int[,] arr2 = {
			{7, -6},
		};

		Console.WriteLine(MatrixSolver.IsVectorRow(new Matrix(arr1)));
		Console.WriteLine(MatrixSolver.IsVectorLine(new Matrix(arr2)));
	}
}	