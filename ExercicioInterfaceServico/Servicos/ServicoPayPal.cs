//CLASSE TIPO SERVIÇO, QUARTA CLASSE MONTADA

namespace ExercicioInterfaceServico.Servicos {
    //classe Servico que herda da IServicoPagamentoOnline.
    //é um subTipo do IServicoPagamentoOnline
    class ServicoPayPal : IServicoPagamentoOnline {

        //atributos privados
        private const double TaxaPercentual = 0.02;
        private const double JurosMensais = 0.01;

        //metodo para calcular Juros = ao IServicoPagamentoOnline
        public double Juros(double montante, int meses) {
            return montante * JurosMensais * meses;
        }

        //metodo para calcular a taxa de parcelamento = ao IServicoPagamentoOnline
        public double TaxaParcelamento(double montante) {
            return montante * TaxaPercentual;
        }
    }
}
