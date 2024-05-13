using System;
using System.Collections.Generic;
using CadastroNotas.Models;

namespace CadastroNotas.Controllers
{
    // criação da classe alunoController
    public class AlunoController
    {   
        // declarção da variável aluno do Tipo Aluno
        private Aluno aluno; 

        // método para criar um novo aluno
        // e adicionar as matetérias Portugues e matemática ao aluno

        public void CriarAluno(string nome, double nota1, double nota2)
        {
            aluno = new Aluno(nome);
            aluno.AdicionarMateria("Português", nota1, nota2);
            aluno.AdicionarMateria("Matemática", nota1, nota2);
        }


           // método que adiciona notas ao aluno 
           // se o aluno  existir
        public void AdicionarNotas(double nota1, double nota2)
        {
            if (aluno == null)
            {
                Console.WriteLine("Por favor, crie um aluno antes de adicionar notas.");
                return;
            }


             // cchamada do método AdcionarMateria da classe aluno
             // para adiocionar as matérias e as notas informadas

            aluno.AdicionarMateria("Matéria", nota1, nota2);
        }

        // Método mostrar Boletim que verifica se o aluno
        // está cadastrado
        public void MostrarBoletim()
        {
            if (aluno == null)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
                return;
            }
            

            // criação da variável statusMaterias que armazena
            // e chama o método CalcularStatusMaterias da calsse
            // aluno e através do foreach percorre a lista 
            //statusMaterias e retiorna o status se aluno
            // está ou não cadastrado na matéria
          
            var statusMaterias = aluno.CalcularStatusMaterias();
            foreach (var status in statusMaterias)
            {
                Console.WriteLine(status);
            }
        }
    }
}
