using System.Text;

namespace Task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 2, 4, 8, 7 };
			Console.WriteLine(Task1A(arr));


			Console.WriteLine(Task1B("aaaabaaccbbbccc"));

			var a = new List<int>() {
				1, 2, 3, 4, 5, 6, 7, 8
			};

			foreach (var item in Task1C(a))
				Console.Write(item + " ");
			
		}

		public static int Task1A(int[] arr)
		{
			if (arr is null)
				throw new ArgumentNullException(nameof(arr));

			return (from item in arr
					where item % 2 == 0
					select item).Sum();			
		}

		public static string Task1B(string str)
		{
			if (str is null)
				throw new ArgumentNullException(nameof(str));

			var usedLetters = new HashSet<char>();

			var builder = new StringBuilder(str);
			int i = 0;
			while (i < builder.Length)
			{
				if (usedLetters.Contains(builder[i]))
					builder.Remove(i, 1);
				else
				{
					usedLetters.Add(builder[i]);
					i++;
				}
			}

			return builder.ToString();
		}

		public static List<T> Task1C<T>(List<T> list)
		{
			if (list is null)
				throw new ArgumentNullException(nameof(list));

			int i = 1;
			while (i <= list.Count)
			{
				list.RemoveAt(i-1);
				i++;
			}

			return list;
		}
	}
}