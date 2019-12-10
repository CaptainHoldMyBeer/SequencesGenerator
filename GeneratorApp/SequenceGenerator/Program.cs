using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
            //Dictionary//
			const string dict = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890";
            //Sequence length//
			const int n = 20;
			for (BigInteger i = 0; i < (BigInteger)(Math.Pow(dict.Length, n)); i++)
			{
				StringBuilder pass = new StringBuilder();
				for (int j = n-1; j>=0; j--)
				{
					pass.Append(dict[(int) ((i / (BigInteger) Math.Pow(dict.Length, j)) % dict.Length)]);
				}
				Console.WriteLine(pass);
			}
			Console.ReadKey();
		}

		
	}
}
