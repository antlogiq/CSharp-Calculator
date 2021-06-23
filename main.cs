using System;

class MainClass {
  public static void Main (string[] args) 
	{
		float num1;
		float num2;
		int op;
		float answer = 0;

		Console.Title = "C# Calculator";

    Console.Write ("Enter Your Fist Number: ");
		num1 = float.Parse(Console.ReadLine());

		Console.Write ("Enter Your Second Number: ");
		num2 = float.Parse(Console.ReadLine());

		Console.WriteLine ("Enter Your Operator (1 for add, 2 for subtract, 3 for multiply, 4 for divide): ");
		op = Convert.ToInt16(Console.ReadLine());

		if (op == 1) {
			answer = num1 + num2;
		}
		else if (op == 2) {
			answer = num1 - num2;
		}		
		else if (op == 3) {
			answer = num1 * num2;
		}
		else if (op == 4) {
			answer = num1 / num2;
		}
		Console.WriteLine("Your answer is " + answer);
  }

}