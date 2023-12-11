using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c__explore_concepts.Models
{
    public class ApresentacaoFoots
    {
        public String ClienteNome { get; set; }
        public String AcompanhanteDesejado { get; set; }
        public int ValorASerGastoDesejado { get; set; }
        public String AvaliacaoPrato { get; set; }

        public ApresentacaoFoots(){
            Console.WriteLine($"Seja bem vindo ao Restaurante Foots, Fique a vontade Sr.{ClienteNome} !");
            
        }
        public ApresentacaoFoots(String clienteNome, String acompanhanteDesejado){
            ClienteNome = clienteNome;
            AcompanhanteDesejado = acompanhanteDesejado;
            Console.WriteLine($"Sejam bem vindos ao Restaurante Foots {ClienteNome} e {AcompanhanteDesejado}, Fiquem a vontade !");
            SelecionarCardapios();
        }

        public void SelecionarCardapios(){
                Console.WriteLine("1 - Hamburgão estilo de esquina");
                Console.WriteLine("2 - Hotdog Tradicional");
                Console.WriteLine("3 - Pedaço de Pizza, Calabressa com Queijo");
                string selecaoPrato = Console.ReadLine();
                FinalizacaoDoPedido(selecaoPrato);
        }

        public void FinalizacaoDoPedido(string selecaoPrato){
            Console.WriteLine($"Você escolheu a opção {selecaoPrato}");
            Console.WriteLine($"Aguarde 10 minutos ao seu Pedido");
        }

    }
}