//ANA CAROLINA MARTINS SANTOS TEIXEIRA, DS2A30

/*Objetivo: Simplificar o uso de sistemas compostos, 
reunindo diversas operações internas em uma interface única e acessível ao cliente.*/
using System;
using System.Collections.Generic;

namespace facade {
    // Classe responsável por simular o controle de estoque de produtos
    public class Estoque {
        public void VerificarEstoque(string produto) {
            // Aqui simulamos a verificação do estoque do produto
            Console.WriteLine($"✔ Estoque verificado para o produto: {produto}");
        }
    }
}




