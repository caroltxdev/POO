//ANA CAROLINA MARTINS SANTOS TEIXEIRA, DS2A30
using System;
using System.Collections.Generic;

namespace composite {
    // Classe composta que pode conter arquivos ou outras pastas
    public class Pasta : ArquivoSistema {
        private List<ArquivoSistema> filhos = new List<ArquivoSistema>();

        public Pasta(string nome) : base(nome) {}

        // Adiciona um novo item (arquivo ou pasta)
        public void Adicionar(ArquivoSistema item) {
            filhos.Add(item);
        }

        public override void Exibir(int nivel) {
            // Exibe o nome da pasta com indentação
            Console.WriteLine(new string('-', nivel) + Nome);

            // Exibe todos os elementos contidos dentro da pasta
            foreach (var filho in filhos) {
                filho.Exibir(nivel + 2);
            }
        }
    }
}
