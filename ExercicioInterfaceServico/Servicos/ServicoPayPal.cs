//CLASSE TIPO SERVIÇO, QUARTA CLASSE MONTADA

namespace ExercicioInterfaceServico.Servicos {
    class ServicoPayPal : IServicoPagamentoOnline {


        private const double TaxaPercentual = 0.02;
        private const double JurosMensais = 0.01;

        public double Juros(double montante, int meses) {
            return montante * JurosMensais * meses;
        }

        public double TaxaParcelamento(double montante) {
            return montante * TaxaPercentual;
        }
    }
}
