using Matrixes;

public class MatrixSolver
{
	//матрица квадратная?
	public static bool IsSquare(Matrix matrix)
	{
		return matrix.GetData().GetLength(0) == matrix.GetData().GetLength(1);
	}

	private static bool Diagonal(int num, Matrix matrix)
	{
		if
		 (matrix.GetData().GetLength(1) > matrix.GetData().GetLength(0) ||
			matrix.GetData().GetLength(1) < matrix.GetData().GetLength(0))
		{
			Console.WriteLine("А хрен его знает, наверное false");
			return false;
		}

		for(int indexI = 0; indexI < matrix.GetData().GetLength(1); indexI += 1)
		{
			if(matrix.GetDataElement(indexI, indexI) != num)
			{
				Console.WriteLine($"Ты в глаза долбишься, это {num} по твоему? " + 
				matrix.GetDataElement(indexI, indexI));
				return false;
			}
		}
		Console.WriteLine("Все шикарно, отвечаю");
		return true;
	}
	public static bool IsVectorLine(Matrix matrix)
	{
		return matrix.GetData().GetLength(0) == 1;
	}

	public static bool IsVectorRow(Matrix matrix)
	{
		return matrix.GetData().GetLength(1) == 1;
	}
	//матрица единичная?
	public static bool ImTheOne(Matrix matrix)
	{
		return Diagonal(1, matrix);
	}

	//может матрица нулевая?
	public static bool NullableCheck(Matrix matrix)
	{
		return Diagonal(0, matrix);
	}

	//может матрица морж?
	public static bool IsMorzh(Matrix matrix)
	{
		Console.WriteLine("Нет, это тюлень)");
		return false;
	}

	//поздаровайся с matrix solver-ом
	public static void Dobrichka()
	{
		Console.WriteLine("И тебе доброе утро");
	}

	//ладно шутки в сторону

	//матрица в 21 веке живет
	//даем возмоности быть современным
	//транспанирование
	public static int[,] TransMatrix(Matrix matrix)
	{
		int[,] transMatrix = new int[matrix.GetData().GetLength(1), matrix.GetData().GetLength(0)];
		for(int indexJ = 0; indexJ < matrix.GetData().GetLength(0); indexJ += 1)
		{
			for(int indexI = 0; indexI < matrix.GetData().GetLength(1); indexI += 1)
			{
				transMatrix[indexI, indexJ] = matrix.GetDataElement(indexJ, indexI);
			}
		}

		return transMatrix;
	}


		//Sum бади вонс толд ми де ворлд из гона sum ми
		//Сложение матриц
		public static int[,] SumMatrix(Matrix matrix1, Matrix matrix2)
		{
			if
			(matrix1.GetData().GetLength(0) != matrix2.GetData().GetLength(0) ||
			matrix1.GetData().GetLength(1) != matrix2.GetData().GetLength(1))
			{
				throw new Exception("Матрицы разной размерности");				
			}


			int[,] assumedMatrix = new int
				[matrix1.GetData().GetLength(0), matrix1.GetData().GetLength(1)];
				
			for(int indexJ = 0; indexJ < matrix1.GetData().GetLength(0); indexJ += 1)
			{
				for(int indexI = 0; indexI < matrix1.GetData().GetLength(1); indexI += 1)
				{
					assumedMatrix[indexJ, indexI] = 
						matrix1.GetDataElement(indexJ, indexI) + matrix2.GetDataElement(indexJ, indexI);
				}
			}
						
			return assumedMatrix;	
		}


		//Умножаем на число
		public static int[,] SumMatrixNum(Matrix matrix1, int num)
		{
			int[,] newMatrix = new int
				[matrix1.GetData().GetLength(0), matrix1.GetData().GetLength(1)];



			for(int indexJ = 0; indexJ < matrix1.GetData().GetLength(0); indexJ += 1)
			{
				for(int indexI = 0; indexI < matrix1.GetData().GetLength(1); indexI += 1)
				{
					newMatrix[indexJ, indexI] = 
						matrix1.GetDataElement(indexJ, indexI) * num;
				}
			}
			return newMatrix;
		}


		//без комментариев
		public static int[,] Multiply(Matrix matrix1, Matrix matrix2)
		{
			if(matrix1.GetData().GetLength(1) != matrix2.GetData().GetLength(0))
			{
				throw new Exception("Матрицы нельзя перемножать");
			}

			Console.WriteLine(matrix1.GetData().GetLength(1) * matrix2.GetData().GetLength(0));
			
			int[,] summedMatrix = new int[2,2];
			
			for(int indexI = 0; indexI < matrix1.GetData().GetLength(0); indexI += 1)
			{
				for(int indexJ = 0; indexJ < matrix2.GetData().GetLength(1); indexJ += 1)
				{
					for(int counter = 0; counter < matrix2.GetData().GetLength(0); counter += 1)
					{
						summedMatrix[indexI, indexJ] += matrix1.GetDataElement(indexI, counter) * matrix2.GetDataElement(counter, indexJ);
					}
				}
			}
			
			return summedMatrix;
		}

		//Я уже определившейся
		public static int IKnowWhoAmI(Matrix matrix)
		{
			if(!MatrixSolver.IsSquare(matrix))
			{
				throw new Exception("Матрица не квадратная");
			}

			if(matrix.GetData().GetLength(0) == 2)
			{
				return matrix.GetDataElement(0, 0) * matrix.GetDataElement(1, 1) - matrix.GetDataElement(0, 1) * matrix.GetDataElement(1, 0);
			}
			//Че пацаны, треугольнички?)
			if(matrix.GetData().GetLength(0) == 3)
			{

				return ((
					matrix.GetDataElement(0, 0) * matrix.GetDataElement(1, 1) * matrix.GetDataElement(2, 2)) +
					matrix.GetDataElement(0, 2) * matrix.GetDataElement(1, 0) * matrix.GetDataElement(2, 1) +
					matrix.GetDataElement(0, 1) * matrix.GetDataElement(2, 0) * matrix.GetDataElement(1, 2) - 



					
					
					matrix.GetDataElement(0, 2) * matrix.GetDataElement(1, 1) * matrix.GetDataElement(2, 0) -
					matrix.GetDataElement(0, 1) * matrix.GetDataElement(1, 0) * matrix.GetDataElement(2, 2) -
					matrix.GetDataElement(0, 0) * matrix.GetDataElement(1, 2) * matrix.GetDataElement(2, 1));
			}

			Console.WriteLine("Сам считай)");
			return 0;
		}

		
}