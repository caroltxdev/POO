//ANA CAROLINA MARTINS SANTOS TEIXEIRA, DS2A30
using System;

namespace facade {
    // Classe principal que simula o cliente do sistema
    class Program {
        static void Main(string[] args) {
            // Criamos uma instância da Façade, que simplifica o uso do sistema
            PedidoFacade pedido = new PedidoFacade();

            // Definimos os dados do pedido (produto e valor)
            string produto = "Notebook Gamer";
            double valor = 5999.90;

            // Realizamos o pedido com uma única chamada
            pedido.RealizarPedido(produto, valor);

            // Pausa o programa para exibir o resultado
            Console.ReadLine();
        }
    }
}


/*Justificativa:
Utilizei o padrão Façade para encapsular a lógica dos subsistemas Estoque, 
Pagamento e Entrega dentro da classe PedidoFacade. Dessa forma, o cliente 
consegue realizar um pedido de forma simples, sem precisar conhecer a lógica interna de cada etapa. 
Isso reduz o acoplamento e melhora a manutenibilidade.*/
