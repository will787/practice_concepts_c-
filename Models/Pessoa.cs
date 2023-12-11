using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace c__explore_concepts.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(String nome, String sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private int _idade;
        public String Nome { 
            get => _nome.ToUpper();
            
            set{
                if(value == ""){
                    throw new ArgumentException("O nome não pode ser vázio"); //excessão de argumento espera que trate esse argumento
                }
                _nome = value;
            } 
        }
        public String Sobrenome { get; set; }
        public String NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade { 
            get => _idade;
            set{
                if (value < 0)
                {
                    throw new ArgumentException("Você precisa passar a idade correta");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"O meu nome é {NomeCompleto} e tenho {Idade} anos");
        }
    }
}