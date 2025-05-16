//ANA CAROLINA MARTINS SANTOS TEIXEIRA, DS2A30
namespace composite
{
    // Classe abstrata que representa o componente base da estrutura
    // Pode ser um arquivo ou uma pasta
    public abstract class ArquivoSistema
    {
        public string Nome { get; set; }

        public ArquivoSistema(string nome)
        {
            Nome = nome;
        }

        // Método abstrato que será implementado pelas classes filhas
        public abstract void Exibir(int nivel);
    }
}
