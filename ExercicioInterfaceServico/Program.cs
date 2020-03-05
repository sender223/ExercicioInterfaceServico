using System;
using System.Globalization;
using ExercicioInterfaceServico.Entidades;
using ExercicioInterfaceServico.Servicos;

namespace ExercicioInterfaceServico {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com os dados do contrato");
            Console.Write("Numero: ");
            int numeroContrato = int.Parse(Console.ReadLine());
            Console.Write("Data do Contrato (dd/MM/yyyy): ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor Contrato: ");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o numero de Parcelas: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato meuContrato = new Contrato(numeroContrato, dataContrato, valorContrato);

            ContratoServico contratoServico = new ContratoServico(new ServicoPayPal());
            contratoServico.ProcessamentoContrato(meuContrato, meses);

            Console.WriteLine("Prestação:" );
            foreach (Parcelamento parcelamento in meuContrato.Parcelamento) {
                Console.WriteLine(parcelamento);
            }

            
        }
    }
}
