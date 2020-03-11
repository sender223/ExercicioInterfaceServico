//PROGRAMA PRINCIPAL
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

            //instanciando contrato recebendo como parametro numeroContrato, dataContrato, ValorContrato.
            Contrato meuContrato = new Contrato(numeroContrato, dataContrato, valorContrato);

            //aqui eu instancio o contrato de serviço, passando como parametro a dependencia ServicoPayPal.
            //ele "casa" com o IServicoPagamentoOnline por meio de UpCasting
            ContratoServico contratoServico = new ContratoServico(new ServicoPayPal());
            //depois eu chamo o Metodo Processamento e passos os parametros, meuContrato, Meses.
            contratoServico.ProcessamentoContrato(meuContrato, meses);

            Console.WriteLine("Prestação:" );
            //para cada parcelamento in meuContrato.Parcelamento eu imprimo o parcelamento.
            foreach (Parcelamento parcelamento in meuContrato.Parcelamento) {
                Console.WriteLine(parcelamento);
            }            
        }
    }
}
