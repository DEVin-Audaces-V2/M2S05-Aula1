
using System.Runtime.CompilerServices;
namespace Heranca.Model
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public DateTime DataCriacao { get; set; }

        public Pessoa()
        {
            DataCriacao = DateTime.Now;
        }

        public Pessoa(string nome, string endereco , string telefone) : this() 
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }
    }
}