//ANA CAROLINA MARTINS SANTOS TEIXEIRA, DS2A30
using System;

namespace composite {
    class Program {
        static void Main(string[] args) {
            // Criamos a pasta raiz do sistema de arquivos
            var raiz = new Pasta("C:");

            // Criamos uma subpasta chamada Documentos
            var documentos = new Pasta("Documentos");

            // Adicionamos arquivos dentro da subpasta
            documentos.Adicionar(new Arquivo("arquivo1.txt"));
            documentos.Adicionar(new Arquivo("foto.png"));

            // Criamos outra subpasta dentro de Documentos
            var projetos = new Pasta("Projetos");
            projetos.Adicionar(new Arquivo("projeto1.cs"));
            projetos.Adicionar(new Arquivo("README.md"));

            // Inserimos essa subpasta na pasta Documentos
            documentos.Adicionar(projetos);

            // Agora adicionamos tudo na raiz
            raiz.Adicionar(documentos);
            raiz.Adicionar(new Arquivo("sistema.log"));

            // Exibe a estrutura de pastas e arquivos com indentação
            raiz.Exibir(0);

            Console.ReadLine();
        }
    }
}

/*O padrão Composite foi utilizado para representar uma estrutura de arquivos e pastas, onde elementos simples (Arquivo) e compostos (Pasta) são tratados de forma uniforme.
A classe abstrata ArquivoSistema define o contrato comum, e tanto Arquivo quanto Pasta implementam esse comportamento. 
Assim, o cliente pode manipular qualquer item da hierarquia sem se preocupar se está lidando com um arquivo individual ou uma pasta com elementos internos.
Esse padrão é ideal para estruturas em árvore, e sua aplicação melhora a legibilidade e a manutenção do código.*/
