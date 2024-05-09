using System;
namespace CadastroNotas.Models
{   // criação da classe Aluno
    public class Aluno
    { // declaração das propriedades 
        public string Nome{ get; set; }
        public double Nota1{ get; set; }
        public double Nota2 { get; set; }

        // criação do método construtor da classe Aluno
        // para inicializar os atributos da classe que serão
        // passados como parâmetro pelo usuário
        
        public Aluno(string nome,double nota1, double nota2)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
        }

           // Criação da função para calcular Média
         public double CalcularMedia()
         {
            return (Nota1+Nota2)/2;
         }
    }
}
