namespace CICDGruppe5
{

    // Blood rituals *Smørk*
    public interface ICalculator
    {
        int Add(int a, int b);
        double? Divide(double a, double b);
        int Multiply(int a, int b);
        int Subtract(int a, int b);
        double Power(double a, double b);
        double SquareRoot(double a);
    }
}