using System;
using CadastroNotas.Controllers;
using CadastroNotas.Views;

namespace CadastroNotas
{
    class Program
    {
        static void Main(string[] args)
        {

             // criada uma instância da classe AlunoController
            // e atribuída essa instância à variável controller
            // que permite que seja utilizado  os métodos 
            // e propriedades da classe AlunoController
            // para manipular os objetos Aluno 

            AlunoController controller = new AlunoController();
            
            // decçaração da variável Sair como False,
            // onde enquanto essa condsiçao não for true
            // o loop é executado
            bool sair = false;
            while (!sair)
            {
                // calmada ExibirMenu da View.
                View.ExibirMenu();
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    // case 1: o usuário informará o nome do aluno 
                    // e nota1 e nota2 
                    case "1":
                        View.LimparTela();
                        Console.WriteLine("Digite o nome do aluno:");
                        string nomeAluno = Console.ReadLine();
                        Console.WriteLine("Digite as notas para o aluno (Nota1 Nota2):");
                        // array notas para armazenar as notas, nota1 e nota2 
                        // informadas ´pelo usuário separadas por um espaço
                        // utilizando o método .Split(' ')
                        string[] notas = Console.ReadLine().Split(' ');
                         
                       // se a quantidade de notas for diferente de 2
                       // o sistema vai informar ao usuário para informar
                       // as duas notas 

                        if (notas.Length != 2)
                        {
                            Console.WriteLine("Por favor, insira duas notas separadas por espaço.");
                            break;
                        }

                        double nota1, nota2;
                        
                        // verifica se as notas informadas pelo usuário
                        // podem ser convertidas para double se não for
                        // possivel retorna a mensagem de erro

                        if (!double.TryParse(notas[0], out nota1) || !double.TryParse(notas[1], out nota2))
                        {
                            Console.WriteLine("Por favor, insira notas válidas.");
                            break;
                        }

                        controller.CriarAluno(nomeAluno, nota1, nota2);
                        Console.WriteLine("Aluno cadastrado com sucesso!");
                        break;

                        // Case 2: O mètodo LimapraTela() é clamado ta View
                        // e na swquência o método .ExibirBoletim()
                        // é chamado da view com a respota do controller
                        // Exibindo o Boltem 
                    case "2":
                        View.LimparTela();
                        View.ExibirBoletim(controller);
                        break;

                        // case 3: sai do Programa
                    case "3":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                View.LimparTela();
            }
        }
    }
}
