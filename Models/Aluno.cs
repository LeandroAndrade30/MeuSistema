using System;
using System.Collections.Generic;

namespace CadastroNotas.Models
{   
    // criação da classe Aluno
    public class Aluno
    {
        // declarção dos atributos da classe Aluno
        public string Nome { get; set; }

        // Criação do Atributo Lista Materias
        public List<Materia> Materias { get; set; }
        
        // criação do Construtor Aluno passando o parâmetro nome
        public Aluno(string nome)
        {
            Nome = nome; // inicialização dos atributos da calsse Aluno
            
            Materias = new List<Materia>();
        }


         // Criação do método AdicionarMateria 
         // que adciona as materoas a lista Materia
        public void AdicionarMateria(string nomeMateria, double nota1, double nota2)
        {
            Materias.Add(new Materia(nomeMateria, nota1, nota2));
        }


        // Método que adciona uma recuperação
        // a uma determoinada Materia dentro de uma lista
        // de Materias
        public void AdicionarRecuperacao(string nomeMateria, double notaRecuperacao)
        {

            //  foreach percorre a lista de Materias
            // procurando por uma materia por nome específico
            // se encontrar a Materia Atribui a nota de Recuperação
            // para essa Materia e encerra o loop
            // se a Materia não for encontrada a nota de Recuperação
            // não é adicionada

            foreach (var materia in Materias)
            {
                if (materia.Nome == nomeMateria)
                {
                    materia.NotaRecuperacao = notaRecuperacao;
                    break;
                }
            }
        }
         
       //Método para Calcular o status de cada Materia do aluno
       // com base e suas notas e me´dias obtidas

        public List<string> CalcularStatusMaterias()
        {
            // Criação da Lista  statusMaterias 
            // para armazenar o status das Materias
            List<string> statusMaterias = new List<string>();


            // foreach que percorre a Lista Materias
            // e faz o cálculo da media entre as duas notas
            // das duas Materias, onde a média da materia for  
            // maior ou igual a 7.0 vai adciocionar a lista 
            // statusMaterias o nome da meteria e o 
            //status Aprovado com média
            // (com o valor da media)
            // Senão se a nota de Recuperação for diferente 
            //de vazia e NotaRecperação e a media for maior
            // ou igual a 5.0 será adiocinado a lista de 
            // statusMaterias o nome da Meteria e o status 
            // Aprovado após recuperação com média(com o 
            //valor da media) senão a lista statusMaterias
            // recebe o nome da materia e o sttaus reprovado
            foreach (var materia in Materias)
            {
                double media = (materia.Nota1 + materia.Nota2) / 2;

                if (media >= 7.0)
                {
                    statusMaterias.Add($"{materia.Nome}: Aprovado com média {media.ToString("F2")}");
                }
                else
                {
                    if (materia.NotaRecuperacao != null && (media + materia.NotaRecuperacao) / 2 >= 5.0)
                    {
                        statusMaterias.Add($"{materia.Nome}: Aprovado após recuperação com média {(media + materia.NotaRecuperacao) / 2:F2}");
                    }
                    else
                    {
                        statusMaterias.Add($"{materia.Nome}: Reprovado com média {media.ToString("F2")}");
                    }
                }
            }

            return statusMaterias;
        }
    }

    

    // Criação da calsse Materia
    public class Materia
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double? NotaRecuperacao { get; set; }


        // Criação do Construtor Materia da Classe Materia
        public Materia(string nome, double nota1, double nota2)
        {
            Nome = nome;
            Nota1 = nota1;          
            Nota2 = nota2;
            NotaRecuperacao = null;
        }
    }
}

    

