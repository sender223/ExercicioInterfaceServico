//CLASSE TIPO SERVIÇO, TERCEIRA CLASSE MONTADA

namespace ExercicioInterfaceServico.Servicos {
    //classe do tipo interface. Define um conjunto de operações que uma classe ou struct deve
    //implementar.
    //a interface estabelece um contrato que a classe (ou struct) deve cumprir
    interface IServicoPagamentoOnline {

        //operação - define apenas o contrato que a classe
        //ServicoPayPal deve cumprir. 
        //operação TaxaParcelamento recebendo como parametro montante do tipo double
        double TaxaParcelamento(double montate);
        //operação Juros recebendo como parametro montante do tipo double, meses do tipo int
        double Juros(double montante, int meses);
    }
}
