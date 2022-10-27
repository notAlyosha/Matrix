namespace Matrixes
{
	public class Matrix
	{
		private int[,] _data { get; set; }
		public Matrix(int[,] matrixData)
		{
			_data = matrixData;
		}

		public int[,] GetData()
		{
			return _data;
		}
		public int GetDataElement(int indexJ, int indexI)
		{
			return _data[indexJ, indexI];
		}

		public void SetDataElement(int indexJ, int indexI, int value)
		{
			_data[indexJ, indexI] = value;
		}

		public void ShowYourSelf()
		{
			Console.WriteLine("Я покажу тебе свою душу");
			for(int indexJ = 0; indexJ < _data.GetLength(0); indexJ += 1)
			{
				for(int indexI = 0; indexI < _data.GetLength(1); indexI += 1)
				{
					Console.Write(Convert.ToString(_data[indexJ, indexI]) + '\t');
				}
				Console.WriteLine();
			}
		}

		~Matrix()
		{
			Console.WriteLine("Good days honney:\")");
		}
	}
}