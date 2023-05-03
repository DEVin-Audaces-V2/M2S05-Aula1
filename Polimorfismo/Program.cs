using Polimorfismo.Model;
using Polimorfismo.Model.Pessoas;


Cartao cartaoDebito = new CartaoDebito();

cartaoDebito.Creditar(100);
cartaoDebito.Debitar (50);

Cartao cartaoCredito = new CartaoCredito();

cartaoCredito.Creditar(100);
cartaoCredito.Debitar (50);

Console.WriteLine(cartaoDebito.Saldo);

Console.WriteLine(cartaoCredito.Saldo);


Pessoa professor = new Professor("Vanessa", "rua ", "123", "Poo");

Pessoa aluno = new Aluno("Willian", "Rua", "987", 6);

Console.WriteLine(professor.ConverterTexto());

Console.WriteLine(aluno.ConverterTexto());

Console.WriteLine(aluno.ToString());
Console.WriteLine(professor.ToString());
