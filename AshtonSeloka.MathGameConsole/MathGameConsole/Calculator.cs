using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameConsole
{
	internal class Calculator
	{
		Random random = new Random();
		int numberOne = 0;
		int numberTwo = 0;
		double scoreAsInt = 0;

		/// <summary>
		/// Generates Two Random Numbers and performes an addition operation then compares them to user Input
		/// </summary>
		/// <returns>User Score</returns>
		public double Addition() 
		{
			Console.Clear();

			for (int i = 0; i < 5; i++)
			{
				numberOne = random.Next(0, 100);
				numberTwo = random.Next(0, 100);
				int correctAnswer = numberOne + numberTwo;

				
				Console.WriteLine("What is " + numberOne + " + " + numberTwo);
				int? userAnswer = int.Parse(Console.ReadLine());

				if (userAnswer == correctAnswer)
				{
					Console.WriteLine("Correct!!!\n");
					scoreAsInt++;
				}
				else
				{
					Console.WriteLine("Better luck next time\n");

				}
			}
			Console.WriteLine($"Your score is: {scoreAsInt} out of 5 \n");
			Thread.Sleep(2000);
			return scoreAsInt;
		}

		/// <summary>
		/// Generates Two Random Numbers and performes an subtraction operation then compares them to user Input
		/// </summary>
		/// <returns>USer Score</returns>
		public double Subtraction()
		{
			Console.Clear();

			for (int i = 0; i < 5; i++)
			{
				numberOne = random.Next(0, 100);
				numberTwo = random.Next(0, 100);
				int correctAnswer = numberOne - numberTwo;

				
				Console.WriteLine("What is " + numberOne + " - " + numberTwo);
				int? userAnswer = int.Parse(Console.ReadLine());


				if (userAnswer == correctAnswer)
				{
					Console.WriteLine("Correct!!!\n");
					scoreAsInt++;
				}
				else 
				{
					Console.WriteLine("Better luck next time\n");
				
				}
			}
			Console.WriteLine($"Your score is: {scoreAsInt} out of 5 ");
			Thread.Sleep(2000);
			return scoreAsInt;
		}

		/// <summary>
		/// Generates Two Random Numbers and performes an multipication operation then compares them to user Input
		/// </summary>
		/// <returns>USer Score</returns>

		public double Multiplication()
		{
			Console.Clear();

			for (int i = 0; i < 5; i++)
			{
				numberOne = random.Next(0, 100);
				numberTwo = random.Next(0, 100);
				int correctAnswer = numberOne * numberTwo;

				
				Console.WriteLine("What is " + numberOne + " * " + numberTwo);
				int? userAnswer = int.Parse(Console.ReadLine());

				if (userAnswer == correctAnswer)
				{
					Console.WriteLine("Correct!!!\n");
					scoreAsInt++;
				}
				else
				{
					Console.WriteLine("Better luck next time\n");

				}
			}
			Console.WriteLine($"Your score is: {scoreAsInt} out of 5 ");
			Thread.Sleep(2000);
			return scoreAsInt;
		}

		/// <summary>
		/// Generates Two Random Numbers and performes an divison operation then compares them to user Input
		/// </summary>
		/// <returns>USer Score</returns>
		public double division()
		{
			Console.Clear();

			for (int i = 0; i < 5; i++)
			{
				numberOne = random.Next(0, 100);
				numberTwo = random.Next(0, 100);

				while (numberOne%numberTwo !=0) 
				{
					numberOne = random.Next(0, 100);
				}

				int correctAnswer = numberOne / numberTwo;

				
				Console.WriteLine("What is " + numberOne + " / " + numberTwo);
				int? userAnswer = int.Parse(Console.ReadLine());

				if (userAnswer == correctAnswer)
				{
					Console.WriteLine("Correct!!!\n");
					scoreAsInt++;
				}
				else
				{
					Console.WriteLine("Better luck next time\n");

				}
			}
			Console.WriteLine($"Your score is: {scoreAsInt} out of 5 ");
			Thread.Sleep(2000);
			return scoreAsInt;
		}
	}
}
