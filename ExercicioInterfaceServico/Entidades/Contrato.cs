//SEGUNDA CLASSE CRIADA
using System;
using System.Collections.Generic;

namespace ExercicioInterfaceServico.Entidades {
    class Contrato {

        public int NumContrato { get; set; }
        public DateTime DataContrato { get; set; }
        public double ValorTotalContrato { get; set; }
        public List<Parcelamento> Parcelamento { get; set; }

        public Contrato(int numContrato, DateTime dataContrato, double valorTotalContrato) {
            NumContrato = numContrato;
            DataContrato = dataContrato;
            ValorTotalContrato = valorTotalContrato;
            Parcelamento = new List<Parcelamento>();
        }

        public void AdicionarParcelamento(Parcelamento parcelamento) {
            Parcelamento.Add(parcelamento);
        }

    }
}
