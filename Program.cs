﻿using System;
using abstracao.classes;

namespace abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto = new Boleto();
            // Cartao cartao = new Cartao();
            Credito credito = new Credito();
            Debito debito = new Debito();
            boleto.valores = 2000;
            boleto.parcelas = 3;
            credito.bandeira = "Visa";
            credito.cvv = "12234";
            credito.limite = 2400;
            credito.parcelas = 23;
            credito.valores = 3212;


        }
    }
}
