using System;

delegate int MathOperation(int a, int b);

public class Test
{
    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    static int Multiply(int a, int b) => a * b;
    static int Divide(int a, int b) => a / b;
    
	public static void Main()
	{
		MathOperation operation = Add;
		Console.WriteLine("Add Result = " + operation(10, 5));
		
		operation = Subtract;
		Console.WriteLine("Subtract Result = " + operation(10, 5));
		
		operation = Multiply;
		Console.WriteLine("Multiply Result = " + operation(10, 5));
		
		operation = Divide;
		Console.WriteLine("Divide Result = " + operation(10, 5));
	}
}
