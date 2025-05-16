//ANA CAROLINA MARTINS SANTOS TEIXEIRA, DS2A30
namespace decorator
{
    // Classe concreta que implementa a interface IMensagem
    // Representa uma mensagem padrão, sem nenhuma modificação
    public class MensagemSimples : IMensagem
    {
        public string Formatar()
        {
            return "Olá, usuário!";
        }
    }
}
