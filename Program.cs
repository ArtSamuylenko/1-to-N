namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			int k = 1;
			int s = 0;
			int N = Convert.ToInt32(Console.ReadLine());
			do
			{
				s += k;
				++k;
			}
			while (k <= N);
			Console.WriteLine("Sum = {0}", s);
		}
	}
}