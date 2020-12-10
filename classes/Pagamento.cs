using System;

namespace abstracao.classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        protected float valor;

        public string Cancelar(){
            return "";
        }

        // Obrigatorio
        public abstract double Desconto(double valor);

        public abstract string Juros(int parcelas);
    }
}