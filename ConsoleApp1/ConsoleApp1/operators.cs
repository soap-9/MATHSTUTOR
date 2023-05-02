internal class Operator
{
    public string Symbol { get; }

    public Operator(string symbol)
    {
        Symbol = symbol;
    }
}
internal class MathsHelper
{
    public static int Calculate(int a, Operator op, int b)
    {
        switch (op.Symbol)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                return a / b;
            default:
                throw new ArgumentException($"Invalid operator symbol: {op.Symbol}");
        }
    }
}

