using System;

// Declare a delegate for a binary operation
public delegate int BinaryOperation(int a, int b);

class Calculator
{
    // Method that takes two integers and a binary operation delegate
    public int PerformOperation(int x, int y, BinaryOperation operation)
    {
        return operation(x, y);
    }
}

class Program
{
    // Methods that match the delegate signature
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static void Main()
    {
        // Create an instance of the Calculator class
        Calculator calculator = new Calculator();

        // Create instances of the delegate, pointing to the Add and Subtract methods
        BinaryOperation addOperation = new BinaryOperation(Add);
       
        BinaryOperation subtractOperation = new BinaryOperation(Subtract);

        // Use the calculator with different operations
        int resultAdd = calculator.PerformOperation(5, 3, addOperation);
        int resultSubtract = calculator.PerformOperation(5, 3, subtractOperation);

        // Display the results
        Console.WriteLine("Addition result: " + resultAdd);
        Console.WriteLine("Subtraction result: " + resultSubtract);
    }
}
