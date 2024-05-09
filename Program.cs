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
            var controller = new AlunoController();

            // Loop Wihle que enquanto a codição for verdadeira
            // o loop é executado solicitando as informações
            // ao usuário

            while (true)
            {
                 // Chamada do Método ExibirMenu da View.
                 // que exeibe o menu ao usuário
                View.ExibirMenu();
                string opcao = Console.ReadLine();
                
                // Utilização do switch case
                // para que o usuário escolha o opção 
                // desejanada do menu

                switch (opcao)
                {

                    // case 1: solicitará para que o usuário 
                    // informe o Nome do Aluno, Nota1 e Nota2
                    case "1":
                        Console.Write("Nome do aluno: ");
                        string nome = Console.ReadLine();
                        Console.Write("Nota 1: ");
                        double nota1 = double.Parse(Console.ReadLine());
                        Console.Write("Nota 2: ");
                        double nota2 = double.Parse(Console.ReadLine());
                        controller.CadastrarAluno(nome, nota1, nota2);
                        break;

                       // case 2: Limpará a tela chamando o método
                       // LimparTela da View e chama 
                       // o método ExibirBoletim da View
                       // para exibir as informações do boletim
                      // a patir da resposta do Controller(AlunoController)
                      // que contém as informações do Boletim do Aluno
                      
                      
                    case "2":

                        View.LimparTela();
                        View.ExibirBoletim(controller);
                        break;

                    // case 3: Se o usuário escolher a opção 3
                    // sairá do programa

                    case "3":

                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                View.LimparTela();
            }
        }
    }
}

