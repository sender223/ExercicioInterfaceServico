//PRIMEIRA CLASSE CRIADA
using System;
using System.Globalization;


namespace ExercicioInterfaceServico.Entidades {
    
    class Parcelamento {

        //propriedade autoimplementadas para DataVencimento e Montante
        public DateTime DataVencimento { get; set; }
        public double Montante { get; set; }

        //construtor padrão
        public Parcelamento(DateTime dataVencimento, double montante) {
            DataVencimento = dataVencimento;
            Montante = montante;            
        }
        //metodo para imprimir a classe no formato string. 
        public override string ToString() {
            return DataVencimento.ToString("dd/MM/yyyy")
                + " - "
                + Montante.ToString("F2", CultureInfo.InstalledUICulture);
        }
    }
}
