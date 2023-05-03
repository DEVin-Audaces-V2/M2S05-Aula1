
namespace Polimorfismo.Model
{
    public class CartaoCredito : Cartao
    {
        public override void Creditar(double valor){
            Saldo -= valor;
        } 

        public override void Debitar(double valor){
            Saldo += valor;
        }
    }
}