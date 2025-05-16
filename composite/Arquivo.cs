//ANA CAROLINA MARTINS SANTOS TEIXEIRA, DS2A30
using System;

namespace composite {
    // Classe que representa um "nó folha" na árvore
    // Ou seja, um item que não contém outros elementos
    public class Arquivo : ArquivoSistema {
        public Arquivo(string nome) : base(nome) {}

        public override void Exibir(int nivel) {
            // Imprime o nome do arquivo com indentação
            Console.WriteLine(new string('-', nivel) + Nome);
        }
    }
}
