using DesignPatterns.GoF.FactoryMethod.Enums;
using DesignPatterns.GoF.FactoryMethod;

namespace DesignPatterns.GoF.FactoryMethod
{
    public class ExecutaDesignPattern
    {
        public void Executar()
        {
            int tipoServico = 0;
            var executaServico = new ExecutaServico();
            var continuar = true;

            Console.WriteLine("Selecione o tipo de serviço:\n");
            Console.WriteLine("0 - CoberturaServico");
            Console.WriteLine("1 - MasterServico");
            Console.WriteLine("2 - PremiumServico");
            Console.WriteLine("3 - Tradicional\n");

            while (continuar)
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Digite no númeo da opções desejada: \n");
                        tipoServico = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (ArgumentException ex)
                    {
                        tipoServico = -1;
                        Console.WriteLine("\nDigite apenas números entre 1 e 5\n");
                    }

                } while (!(tipoServico >= 0 && tipoServico <= 5));


                var servico = executaServico.GetServico((eTiposServicos)tipoServico);

                Console.WriteLine("\n1 - Sim\n2 - Não\nDeseja calcular outro serviço? (Selecione a opção desejada)");
                var resp = Convert.ToInt32(Console.ReadLine());

                continuar = resp == 1 ? true : false;
            }
        }
    }
}
