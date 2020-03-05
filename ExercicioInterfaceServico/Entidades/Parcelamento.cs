//PRIMEIRA CLASSE CRIADA
using System;
using System.Globalization;


namespace ExercicioInterfaceServico.Entidades {
    class Parcelamento {

        public DateTime DataVencimento { get; set; }
        public double Montante { get; set; }


        public Parcelamento(DateTime dataVencimento, double montante) {
            DataVencimento = dataVencimento;
            Montante = montante;            
        }

        public override string ToString() {
            return DataVencimento.ToString("dd/MM/yyyy")
                + " - "
                + Montante.ToString("F2", CultureInfo.InstalledUICulture);
        }
    }
}
