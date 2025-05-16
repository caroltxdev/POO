//ANA CAROLINA MARTINS SANTOS TEIXEIRA, DS2A30
namespace facade
{
    // Esta é a classe Façade, que centraliza e simplifica a interação com os subsistemas
    public class PedidoFacade
    {
        private Estoque estoque;
        private Pagamento pagamento;
        private Entrega entrega;

        // No construtor, instanciamos as dependências internas
        public PedidoFacade()
        {
            estoque = new Estoque();
            pagamento = new Pagamento();
            entrega = new Entrega();
        }

        // Método principal que encapsula todo o processo de pedido
        public void RealizarPedido(string produto, double valor)
        {
            Console.WriteLine("=== Iniciando pedido ===");

            // Passo 1: Verifica se o produto está disponível no estoque
            estoque.VerificarEstoque(produto);

            // Passo 2: Processa o pagamento do produto
            pagamento.ProcessarPagamento(valor);

            // Passo 3: Agenda a entrega do produto
            entrega.AgendarEntrega(produto);

            Console.WriteLine("=== Pedido finalizado ===");
        }
    }
}
