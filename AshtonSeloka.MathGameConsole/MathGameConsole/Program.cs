using MathGameConsole;

double? score = 0;
string? playerName= string.Empty;
List<string> History = new List<string>();
Calculator calculator = new Calculator();
DateTime? date = null;


Console.WriteLine("What is your Name");
playerName  = Console.ReadLine();

while (true) 
{
	Console.Clear();

	//Displays menu item  5 history only when history is present
	if (History == null)
	{
		Console.WriteLine($"\nWhat Game Would you like to play {playerName}: \n 1) Addition \n 2) Subtraction \n 3) Division \n 4) multiplication");
	}
	else 
	{
		Console.WriteLine($"\nWhat Game Would you like to play {playerName}: \n 1) Addition \n 2) Subtraction \n 3) Division \n 4) multiplication \n 5) History");
	}
	
	int? userInput = int.Parse(Console.ReadLine());


	switch (userInput) 
	{
		case 1:
			score = calculator.Addition();
			date = date ?? DateTime.Now;
			History.Add($"User: {playerName}, Score: {score}/5, Date:{date}");
			break;

		case 2:
			score = calculator.Subtraction();
			date = date ?? DateTime.Now;
			History.Add($"User: {playerName}, Score: {score}/5, Date:{date}");
			break;

		case 3:
			score=calculator.Division();
			date = date ?? DateTime.Now;
			History.Add($"User: {playerName}, Score: {score}/5, Date:{date}");
			break;

		case 4:
			score = calculator.Multiplication();
			date = date ?? DateTime.Now;
			History.Add($"User: {playerName}, Score: {score}/5, Date:{date}");
			break;
		case 5:
			while (true)
			{
				foreach (string s in History)
				{
					Console.WriteLine(s);
				}
				Console.WriteLine("Press any key to exit");
				int exit = int.Parse(Console.ReadLine());

				if (exit !=null)
				{
					Console.Clear();
					break;

				}
			}

			break;
	}
}

