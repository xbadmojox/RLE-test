using System;
using System.Text;


namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("архивация");
			String cod = Console.ReadLine();
			string str1 = cod, str = "", ch = "";
			int i, k, j;
			for (i = 0; i < str1.Length;)
			{ 
				ch = str1.Substring(i, 1); 
				k = 0; 
				if (i == str1.Length - 1)
				{ 
					str += Convert.ToString(ch);
					break; 
				}

				if (str1.Substring(i + 1, 1) == ch)
				{
					for (j = i; j < str1.Length; j++)
					{
						if (str1.Substring(j, 1) == ch) 
							k++; 
						else
							break; 
					}
					i = j;
				}
				else
					i++;

				if (k != 0)
					str += Convert.ToString(k) + Convert.ToString(ch);
				else
					str += Convert.ToString(ch);

			}


			Console.WriteLine("разархивация");
			string text = Console.ReadLine();
		
			StringBuilder output = new StringBuilder();		
			 StringBuilder num = new StringBuilder();
			foreach (char symbol in text)
			{			
				if (char.IsDigit(symbol))
					num.Append(symbol);
				else
				{
					for (int f = 0; f < int.Parse(num.ToString()); f++)
						output.Append(symbol);
					num.Clear();
				}
			}
			Console.WriteLine("архивация-выход");
			Console.WriteLine(str);
			Console.WriteLine("разархивация-выход");
			Console.WriteLine(output);
			
			Console.ReadLine();
		}
	}
}
