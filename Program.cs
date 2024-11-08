using System;

public class Program
{
    public static void Main()
    {
        var model = new CalculatorModel();
        var view = new CalculatorView();
        var controller = new CalculatorController(model, view);

        Console.WriteLine("Welcome to the Calculator!");
        controller.PerformCalculation();
    }
}
