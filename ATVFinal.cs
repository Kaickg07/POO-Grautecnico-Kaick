using System;
using System.Linq;

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


            Cliente meucliente1 = new Cliente("Kaick Gomes","143.976.546-43","(83)4002-8922","Rua João Pessoa","Kaickgomes3@gmail.com");
            Cliente meucliente2 = new Cliente("Enzo Silveira","254.891.032-15","(81)3221-4005","Rua das Flores","Enzosilveira8@gmail.com");
            Cliente meucliente3 = new Cliente("Lívia Medeiros","762.145.980-22","(84)98877-1234","Avenida Brasil","Liviamedeiros.contato@gmail.com");
            Cliente meucliente4 = new Cliente("Thiago Cavalcanti","109.334.657-88","(83)3244-1010","Rua Duque de Caxias","Thicavalcanti99@gmail.com");
            Cliente meucliente5 = new Cliente("Beatriz Viana","445.009.123-56","(11)4004-0000","Alameda dos Anjos","Biaviana.vendas@gmail.com");
            Cliente meucliente6 = new Cliente("Matheus Rocha","918.273.645-09","(21)2506-7000","Rua Sete de Setembro","Matheusrocha_dev@gmail.com");
            Cliente meucliente7 = new Cliente("Camila Antunes","332.556.778-11","(31)3409-5000","Avenida Getúlio Vargas","Camilantunes22@gmail.com");
            Cliente meucliente8 = new Cliente("Felipe Dantas","554.120.339-44","(85)3366-7300","Rua Major Facundo","Felipe.dantas.work@gmail.com");
            Cliente meucliente9 = new Cliente("Isabela Pontes","667.889.001-37","(71)3115-1111","Rua da Paciência","Isabelapontes.office@gmail.com");
            Cliente meucliente10 = new Cliente("Gustavo Lins","002.443.556-28","(61)3212-1000","Eixo Monumental","Gustavolins.pro@gmail.com");
            
            Livro meulivro1 = new Livro("Fogo e sangue","R.R Martin",2018,"9788556510761","Suma","Disponível");
            Livro meulivro2 = new Livro("Harry Potter e a Pedra Filosofal","J.K. Rowling",1997,"9788532530783","Bloomsbury","Disponível");
            Livro meulivro3 = new Livro("O Diário de Anne Frank","Anne Frank",1947,"9788501044457","Contact Publishing","Indisponível");
            Livro meulivro4 = new Livro("Fogo e sangue","R.R Martin",2018,"9788556510761","Suma","Disponível");
            Livro meulivro5 = new Livro("O Diário de Anne Frank","Anne Frank",1947,"9788501044457","Contact Publishing","Disponível");
            Livro meulivro6 = new Livro("Harry Potter e a Pedra Filosofal","J.K. Rowling",1997,"9788532530783","Bloomsbury","Disponível");
            Livro meulivro7 = new Livro("Fogo e sangue","R.R Martin",2018,"9788556510761","Suma","Disponível");
            Livro meulivro8 = new Livro("Dom Quixote","Miguel de Cervantes",1605,"9788424115456","Francisco de Robles","Indisponível");
            Livro meulivro9 = new Livro("Fogo e sangue","R.R Martin",2018,"9788556510761","Suma","Disponível");
            Livro meulivro10 = new Livro("Dom Quixote","Miguel de Cervantes",1605,"9788424115456","Francisco de Robles", "Indisponível");
            Emprestimo meuemprestimo1 = new Emprestimo(meulivro2,meucliente5,10);
            Emprestimo meuemprestimo2 = new Emprestimo(meulivro3,meucliente1,1);
            Emprestimo meuemprestimo3 = new Emprestimo(meulivro4,meucliente7,3);
            Emprestimo meuemprestimo4 = new Emprestimo(meulivro7,meucliente2,5);
            Emprestimo meuemprestimo5 = new Emprestimo(meulivro6,meucliente3,20);
            Emprestimo meuemprestimo6 = new Emprestimo(meulivro1,meucliente4,0);
            Emprestimo meuemprestimo7 = new Emprestimo(meulivro5,meucliente8,1);
            Emprestimo meuemprestimo8 = new Emprestimo(meulivro9,meucliente6,0);
            Emprestimo meuemprestimo9 = new Emprestimo(meulivro10,meucliente9,7);
            Emprestimo meuemprestimo10 = new Emprestimo(meulivro8,meucliente10,4);

            Console.WriteLine("CLIENTES CADASTRADOS:");
            Cliente [] todosClientes = {meucliente1,meucliente2,meucliente3,meucliente4,meucliente5,meucliente6,meucliente7,meucliente8,meucliente9,meucliente10};
            foreach (var c in todosClientes)
            {
                Console.WriteLine(c.ListarCliente());
            }
            Console.WriteLine("LIVROS CADASTRADOS:");
            Livro [] todosLivros = {meulivro1,meulivro2,meulivro3,meulivro4,meulivro5,meulivro6,meulivro7,meulivro8,meulivro9,meulivro10};
            foreach (var l in todosLivros)
            {
                Console.WriteLine(l.ListarLivro());
            }
            Console.WriteLine("LISTA DE EMPRESTIMOS:");
            Emprestimo [] todosEmprestimos = {meuemprestimo1,meuemprestimo2,meuemprestimo3,meuemprestimo4,meuemprestimo5,meuemprestimo6,meuemprestimo7,meuemprestimo8,meuemprestimo9,meuemprestimo10};
            foreach (var e in todosEmprestimos)
            {
                Console.WriteLine(e.ListarEmprestimos());
            }
            var ranking = todosEmprestimos
            .GroupBy(e => e.Livro.Nome)
            .Select(g => new 
            {
                Livro = g.Key,
                TotalEmprestimos = g.Count()
            })
            .OrderByDescending(r => r.TotalEmprestimos);

            Console.WriteLine("\nRANKING DOS LIVROS MAIS EMPRESTADOS:");
            
            foreach (var item in ranking)
            {
                Console.WriteLine($"Livro: {item.Livro} - Empréstimos: {item.TotalEmprestimos}");
            }

        }
    }
}


