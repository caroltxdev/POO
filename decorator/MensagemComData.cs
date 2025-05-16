//ANA CAROLINA MARTINS SANTOS TEIXEIRA, DS2A30
using System;

namespace decorator {
    // Decorador concreto que adiciona a data à mensagem
    public class MensagemComData : MensagemDecorator {
        public MensagemComData(IMensagem mensagem) : base(mensagem) {}

        public override string Formatar() {
            // Adiciona a data atual antes da mensagem original
            return $"{DateTime.Now.ToShortDateString()} - {mensagem.Formatar()}";
        }
    }
}
