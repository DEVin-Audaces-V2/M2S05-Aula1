namespace Heranca.Model
{
    public class Professor : Pessoa
    {
        public string Especialidade { get; set; }

        public Professor()
        {
            
        }

        public Professor(string nome, string endereco, string telefone, string especialidade )
                            : base( nome, endereco, telefone)
        {
            Especialidade = especialidade;
        }
    }
}