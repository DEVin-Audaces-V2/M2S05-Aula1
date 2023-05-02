
using Heranca.Model;

Pessoa lucas = new Aluno();
lucas.Nome= "Lucas";
lucas.Endereco = "Rua";

//Casting detalhado de aluno
Aluno aluno = (Aluno)lucas;
aluno.Matricula = 5;
//CastingReduzido
((Aluno)lucas).Matricula = 5;

Pessoa alunoEad = new AlunoEAD(){
                      Nome = "João",
                      Endereco ="rua",
                      Matricula = 6,
                      ProvedorInternet= "Vivo",
                  };

Pessoa alunoEad2 = new AlunoEAD("Marco","rua", "45", 8, "Claro");

Pessoa professor = new Professor("Vanessa", "rua ", "123", "Poo");

List<Pessoa> pessoas = new List<Pessoa>();
pessoas.Add(lucas);
pessoas.Add(alunoEad);
pessoas.Add(professor);

//Classe abstrata impede a criação de instancias dela 
//var pessoa = new Pessoa("Josefina", "rua", "987" );

var pesquisa =  pessoas.Find(x=>x.Nome == "Vanessa");


Console.ReadLine();