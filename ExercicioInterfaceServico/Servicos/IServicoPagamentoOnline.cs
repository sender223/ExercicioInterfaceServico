//CLASSE TIPO SERVIÇO, TERCEIRA CLASSE MONTADA

namespace ExercicioInterfaceServico.Servicos {
    interface IServicoPagamentoOnline {

        double TaxaParcelamento(double montate);
        double Juros(double montante, int meses);
    }
}
