namespace Polimorfismo.Model
{
    public abstract class Cartao
    {
        public double Saldo { get; protected set; }

        public abstract void Debitar(double valor);
        public abstract void Creditar (double valor );
    }
}