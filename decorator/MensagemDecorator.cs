//ANA CAROLINA MARTINS SANTOS TEIXEIRA, DS2A30
namespace decorator
{
    // Classe abstrata que também implementa IMensagem
    // Serve como base para os decoradores concretos
    public abstract class MensagemDecorator : IMensagem
    {
        protected IMensagem mensagem;

        // Recebe uma mensagem original e guarda para uso
        public MensagemDecorator(IMensagem mensagem)
        {
            this.mensagem = mensagem;
        }

        // Cada decorador concreto precisa sobrescrever este método
        public abstract string Formatar();
    }
}
