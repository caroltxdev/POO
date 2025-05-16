//ANA CAROLINA MARTINS SANTOS TEIXEIRA, DS2A30
namespace decorator
{
    // Decorador concreto que transforma o texto em letras maiúsculas
    public class MensagemEmMaiusculo : MensagemDecorator
    {
        public MensagemEmMaiusculo(IMensagem mensagem) : base(mensagem) { }

        public override string Formatar()
        {
            // Converte a mensagem original para maiúsculas
            return mensagem.Formatar().ToUpper();
        }
    }
}
