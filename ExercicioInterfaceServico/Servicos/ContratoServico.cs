//CLASSE TIPO SERVIÇO, QUINTA CLASSE MONTADA

using System;
using ExercicioInterfaceServico.Entidades;

namespace ExercicioInterfaceServico.Servicos {
    class ContratoServico {

        private IServicoPagamentoOnline _servicoPagamentoOnline;

        public ContratoServico(IServicoPagamentoOnline servicoPagamentoOnline) {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }

        public void ProcessamentoContrato(Contrato contrato, int meses) {
            double cotaBasica = contrato.ValorTotalContrato / meses;
            for (int i = 1; i <= meses; i++) {
                DateTime data = contrato.DataContrato.AddMonths(i);
                double atualizaCota = cotaBasica + _servicoPagamentoOnline.Juros(cotaBasica, i);
                double cotaCompleta = atualizaCota + _servicoPagamentoOnline.TaxaParcelamento(atualizaCota);
                contrato.AdicionarParcelamento(new Parcelamento(data, cotaCompleta));
            }
        }
    }
}
