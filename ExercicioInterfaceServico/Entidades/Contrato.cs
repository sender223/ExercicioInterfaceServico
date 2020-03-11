//SEGUNDA CLASSE CRIADA
using System;
using System.Collections.Generic;

namespace ExercicioInterfaceServico.Entidades {
    class Contrato {

        //propriedades autoimplementadas
        public int NumContrato { get; set; }
        public DateTime DataContrato { get; set; }
        public double ValorTotalContrato { get; set; }
        public List<Parcelamento> Parcelamento { get; set; }

        //construtor padrão
        public Contrato(int numContrato, DateTime dataContrato, double valorTotalContrato) {
            NumContrato = numContrato;
            DataContrato = dataContrato;
            ValorTotalContrato = valorTotalContrato;
            //instanciamos uma lista
            Parcelamento = new List<Parcelamento>();
        }
        //metodo para adicionar parcela.
        public void AdicionarParcelamento(Parcelamento parcelamento) {
            Parcelamento.Add(parcelamento);
        }

    }
}
