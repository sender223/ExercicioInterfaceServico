//CLASSE TIPO SERVIÇO, QUINTA CLASSE MONTADA

using System;
using ExercicioInterfaceServico.Entidades;

namespace ExercicioInterfaceServico.Servicos {
    class ContratoServico {
        //variavel privada do tipo IServicoPagamentoOnline
        private IServicoPagamentoOnline _servicoPagamentoOnline;

        //com isso, criamos um construtor padrão e acrescentamos _servicoPagamentoOnline
        //como paramentro para receber esse objeto. 
        //"inversão de controle por meio de dependecia
        public ContratoServico(IServicoPagamentoOnline servicoPagamentoOnline) {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }

        //aqui criamos um metodo para o processamento do contrato. 
        public void ProcessamentoContrato(Contrato contrato, int meses) {
            //variavel do tipo double dividindo o contrato.ValorTotalContrato / Meses. 
            double cotaBasica = contrato.ValorTotalContrato / meses;
            //criando um for para calcular o contrato de acordo com a quantidade de meses
            for (int i = 1; i <= meses; i++) {
                //adiciona a data do contrato pela quantia de i, 
                DateTime data = contrato.DataContrato.AddMonths(i);
                //variavel que recebe a cota calculando cotaBasica + metodo _servicoPagamentOnline.Juros 
                //para calcular a cotaBasica, com a quantida de i = mes
                double atualizaCota = cotaBasica + _servicoPagamentoOnline.Juros(cotaBasica, i);
                //variavel que recebe atualizaCota + metodo _servicoPagamentoOnline.TaxaParcelamento(recebendo atualizaCota)
                double cotaCompleta = atualizaCota + _servicoPagamentoOnline.TaxaParcelamento(atualizaCota);
                //chamamos a variavel contrato.AdiconarParcelamento instanciando Parcelamento recebendo data,cotaCompleta)
                contrato.AdicionarParcelamento(new Parcelamento(data, cotaCompleta));
            }
        }
    }
}
