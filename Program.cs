//Че пацаны, матрицы?)
using Matrixes;
class Program
{
	public static void Main()
	{
		int[,] arr1 = {
			{0,  7, 9, 7},
			{27, 0, 12, 6},
			{3,  1, 0, 3},
		};

		int[,] arr2 = {
			{0,  7, 9, 7},
			{27, 0, 12, 6},
			{3,  1, 0, 3},
		};

		Matrix matrix = new Matrix(MatrixSolver.SumMatrixNum(new Matrix(arr1), 5));
		matrix.ShowYourSelf();
	}
}