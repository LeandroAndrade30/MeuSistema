using System;
using CadastroNotas.Controllers;

namespace CadastroNotas.Views
{  
      // criação da classe View
    public class View
    {
        // criação do método para  ExibirMenu ao usuário
        public static void ExibirMenu()
        {
            Console.WriteLine("===== Cadastro de Alunos =====");
            Console.WriteLine("1. Cadastrar Aluno");
            Console.WriteLine("2. Mostrar Boletim");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");
        }

         // método que serve para charmar o método MostrarBoletim
         // da classe AlunoController e exibir na tela o boletim 
         // do aluno

        public static void ExibirBoletim(AlunoController controller)
        {
            Console.WriteLine("===== Boletim =====");
            controller.MostrarBoletim();
            Console.WriteLine("====================");
        }
          
          // Método para limpar a Tela
        public static void LimparTela()
        {
            Console.Clear();
        }
    }
}

