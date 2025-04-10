namespace CICDGruppe5
{
    public interface ICalculator
    {
        int Add(int a, int b);
        double? Divide(double a, double b);
        int Multiply(int a, int b);
        int Subtract(int a, int b);
    }
}