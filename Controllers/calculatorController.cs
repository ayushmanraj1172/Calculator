using System;

public class CalculatorController
{
    private readonly CalculatorModel _model;
    private readonly CalculatorView _view;

    public CalculatorController(CalculatorModel model, CalculatorView view)
    {
        _model = model;
        _view = view;
    }

    public void PerformCalculation()
    {
        try
        {
            var num1 = _view.GetOperand("first number");
            var num2 = _view.GetOperand("second number");
            var operation = _view.GetOperator();
            double result = operation switch
            {
                "+" => _model.Add(num1, num2),
                "-" => _model.Subtract(num1, num2),
                "*" => _model.Multiply(num1, num2),
                "/" => _model.Divide(num1, num2),
                _ => throw new InvalidOperationException("Invalid operation")
            };
            _view.ShowResult(result);
        }
        catch (Exception ex)
        {
            _view.ShowError(ex.Message);
        }
    }
}
