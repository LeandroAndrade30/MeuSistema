using System;
using System.Collections.Generic;
using CadastroNotas.Models;

namespace CadastroNotas.Controllers
{  // criação da classe AlunoController
    public class AlunoController
    {
        //// criando um campo privado
        // para armazenar a lista de Objetos Aluno 
        private List<Aluno> alunos;

        /// Metodo Construtor AlunoController para
       // inicializar a lista de Alunos
        public AlunoController()
        {
            alunos = new List<Aluno>();
        }

        // Método público para cadastrar um novo Aluno na lista
        public void CadastrarAluno(string nome, double nota1, double nota2)
        {
            alunos.Add(new Aluno(nome, nota1, nota2));
        }

          
        // Método para mostrar os dados no boletim

        public void MostrarBoletim(){
            Console.WriteLine("=====Boletim=======");
             // foreach pera percorrer a lista de Alunos
             // para imprimir as informações do Aluno no boletim
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}");
                Console.WriteLine($"Nota 1: {aluno.Nota1}");
                Console.WriteLine($"Nota 2: {aluno.Nota2}");
                Console.WriteLine($"Média: {aluno.CalcularMedia()}");
                Console.WriteLine("====================");
            }
        }
    }
}
