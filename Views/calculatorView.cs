using System;

public class CalculatorView
{
    public double GetOperand(string name)
    {
        Console.Write($"Enter {name}: ");
        return double.TryParse(Console.ReadLine(), out var operand) ? operand : 0;
    }

    public string GetOperator()
    {
        Console.Write("Enter operation (+, -, *, /): ");
        return Console.ReadLine();
    }

    public void ShowResult(double result)
    {
        Console.WriteLine($"Result: {result}");
    }

    public void ShowError(string message)
    {
        Console.WriteLine($"Error: {message}");
    }
}
