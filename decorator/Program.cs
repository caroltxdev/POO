//ANA CAROLINA MARTINS SANTOS TEIXEIRA, DS2A30
using System;

namespace decorator {
    class Program {
        static void Main(string[] args) {
            // Começamos com uma mensagem simples
            IMensagem mensagemBase = new MensagemSimples();

            // Decoramos a mensagem com letras maiúsculas
            IMensagem mensagemMaiuscula = new MensagemEmMaiusculo(mensagemBase);

            // Depois decoramos com a data
            IMensagem mensagemFinal = new MensagemComData(mensagemMaiuscula);

            // Imprimimos a mensagem final no console
            Console.WriteLine(mensagemFinal.Formatar());

            Console.ReadLine();
        }
    }
}

/*O padrão Decorator foi utilizado para permitir adicionar funcionalidades a um objeto (MensagemSimples) de forma flexível, sem precisar alterar sua estrutura original.
Utilizei dois decoradores:
MensagemEmMaiusculo para transformar o texto em letras maiúsculas;
MensagemComData para adicionar a data atual antes da mensagem.
Essa abordagem facilita a extensão de funcionalidades de maneira organizada, mantendo o princípio da programação orientada a objetos: aberto para extensão, fechado para modificação.*/