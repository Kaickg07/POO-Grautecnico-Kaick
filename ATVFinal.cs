using System;

namespace ATVFinal
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Cpf {get;private set;}
        public string Telefone {get;private set;}
        public string Endereco {get;private set;}
        public string Email {get;private set;}

        public Cliente(string nome, string cpf, string telefone, string endereco, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Endereco = endereco;
            Email = email;
        }

        public string ListarCliente()
        {
            return $"O cliente {Nome} pertencente ao CPF {Cpf},com o Telefone {Telefone},morando na {Endereco} e possui o Email {Email} está cadastrado";
        }
    }

    public class Livro
    {
        public string Nome {get;set;}
        public string Autor {get;set;}
        public int Ano {get;set;}
        public string Isbn {get;set;}
        public string Editora { get; set;}
        public string Status {get;set;}

        public Livro(string nome, string autor, int ano, string isbn, string editora, string status)
        {
            Nome = nome;
            Autor = autor;
            Ano = ano;
            Isbn = isbn;
            Editora = editora;
            Status = status;
        }

        public string ListarLivro()
        {
            return $"O livro {Nome} pertencente ao autor {Autor},foi publicado no ano de {Ano},possui o Isbn {Isbn},é da editora {Editora} e esta atualmente {Status}";
        }
    }

    public class Emprestimo
    {
        public Livro Livro {get;set;}
        public Cliente Cliente {get;set;}
        public DateTime DataEmprestimo {get;set;}
        public DateTime DataDevolucao {get;set;}
        public int Multa {get;set;}
        public int Dias {get;set;}

        public Emprestimo(Livro livro, Cliente cliente, int dias)
        {
            Livro = livro;
            Cliente = cliente;
            DataEmprestimo = DateTime.Now;
            Dias = dias;
            Multa = 5 * dias;
        }
        public string ListarEmprestimos()
        {
            if (Dias > 0)
            {
                return $"O livro {Livro.Nome} foi pego por {Cliente.Nome} em {DataEmprestimo} e foi devolvido {Dias} dias após o prazo,sendo cobrado a cada dia uma multa de 5 reais,totalizando {Multa} reais ";
            }
            else
            {
                return $"O livro {Livro.Nome} foi pego por {Cliente.Nome} e devolvido no prazo,não sendo necessário nenhum valor de multa";
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema da biblioteca iniciando...");
            Console.WriteLine("BEM VINDO A BIBLIOTECA");


            Cliente meucliente = new Cliente("Kaick Gomes", "143.976.546-43", "(83)4002-8922", "Rua João Pessoa", "Kaickgomes3@gmail.com");
            Livro meulivro = new Livro("Fogo e sangue", "R.R Martin", 2018, "9788556510761", "Suma", "Disponível");
            Emprestimo meuemprestimo = new Emprestimo(meulivro, meucliente, 1);


            Console.WriteLine(meucliente.ListarCliente());
            Console.WriteLine(meulivro.ListarLivro());
            Console.WriteLine(meuemprestimo.ListarEmprestimos());

        }
    }
}


