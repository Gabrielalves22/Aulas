namespace Aula_11;

public class program
{
    public static void Main()
    {
        // EX 1:
        // Switch
        //bool value = true;
        //switch (value)
        //{
        //    case true:
        //        Console.WriteLine("O valor é true");
        //        break;

        //    case false:
        //        Console.WriteLine("O valor é false");
        //        break;
        //}

        //Ex2:
        //Console.WriteLine("======== Dia da Semana ========");
        //Console.WriteLine("Digite um número de 1 a 7:");
        //int dayOfweek = Convert.ToInt32(Console.ReadLine());

        //switch (dayOfweek)
        //{
        //    case 1:
        //        Console.WriteLine ("O dia da semana é Domingo");
        //        break;
        //    case 2:
        //        Console.WriteLine("O dia da semana é Segunda-feira");
        //        break;
        //    case 3:
        //        Console.WriteLine("O dia da semana é Terça-feira");
        //        break;
        //    case 4:
        //        Console.WriteLine("O dia da semana é Quarta-feira");
        //        break;
        //    case 5:
        //        Console.WriteLine("O dia da semana é Quinta-feira");
        //        break;
        //    case 6:
        //        Console.WriteLine("O dia da semana é Sexta-feira");
        //        break;
        //    case 7:
        //        Console.WriteLine("O dia da semana é Sabado");
        //        break;
        //    default:
        //        Console.WriteLine("Dia invalido! insira um novo numero!");
        //        break;
        //}

        //Ex3:

        bool varContinue = true;

        while (varContinue)
        {
            
            Console.WriteLine("======== Desempenho Escolar ========");
            Console.WriteLine("Digite sua primeira nota: ");
            int score = Convert.ToInt32(Console.ReadLine());
            switch (score)
            {
                case 10:
                case 9:
                    Console.WriteLine("Otimo!");
                    break;

                case 8:
                case 7:
                    Console.WriteLine("Bom!");
                    break;

                case 6:
                    Console.WriteLine("Regular!");
                    break;

                case 5:
                    Console.WriteLine("Ruim!");
                    break;

                default:
                    Console.WriteLine("Horrivel!");
                    break;

            }

            Console.WriteLine("Deseja por uma nova nota? (s/n)");
            string response = Console.ReadLine();
            if (response != "s" && response != "S")
            {
                varContinue = false;
            }

        }
    }
}
