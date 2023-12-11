using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c__explore_concepts.Models
{
    public class Curso
    {
        public String Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }


        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados(){
            int quantidade = Alunos.Count;
            return(quantidade);
        }
        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno);
            //aqui temos um exemplo do método remover, devolve bool por conta do método trazer true
            //executa o método recebendo argumento da lista que é o aluno
        }
        public void ListarAlunos(){
            Console.WriteLine($"Alunos do curso de: {Nome}"); 
            for(int count = 0; count < Alunos.Count; count++)
            {
                string texto = "Number: " + count + " - " + Alunos[count].NomeCompleto;
                Console.WriteLine($"{texto}");
            }
        }
    }
}