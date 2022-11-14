



using DesignPatterns.GoF.Creationals.AbstractFactory.Factories;
using DesignPatterns.GoF.Creationals.AbstractFactory.Factories.Interfaces;


namespace DesignPatterns.GoF.Creationals.AbstractFactory
{
    public static class Cliente
    { 
        public static void Executar()
        {
            var continuar = true;

            while (continuar)
            {
                IFactory factory = null; 

                Console.WriteLine("Rotina de treino A,B e C:");
                Console.WriteLine("1-Segunda Feira e Quinta Feira.");
                Console.WriteLine("2-Terça Feira e Sexta Feira.");
                Console.WriteLine("3-Segunda Feira e Quinta Feira.\n");

                Console.Write("Selecione a rotina de treino você deseja: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        factory = new SegundaQuintaFactory();
                        break;
                    case "2":
                        factory = new TercaSextaFactory();
                        break;
                    case "3":
                        factory = new QuartaSabadoFactory();
                        break;
                    default:
                        break;
                }


                Console.Write("\nDeseja ver outra rotina? (1-Sim ou 2-Não): ");
                var resp = Convert.ToInt32(Console.ReadLine());

                continuar = resp == 1 ? true : false;  
            }

        }

    }
}
