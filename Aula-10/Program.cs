namespace Aula_10;

public class program
{
    public static void Main()
    {
        bool varContinue = true;

        while (varContinue)
        {

            //inicialização
            Console.WriteLine(" ======== Calculadora basica ======== \n");
            Console.WriteLine("Digite o primeiro numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Selecione o tipo de operação
            Console.WriteLine("\nEscolha uma operação: ");
            Console.WriteLine("1 - Adição ( + )");
            Console.WriteLine("2 - Subtração ( - )");
            Console.WriteLine("3 - Multiplicação ( * )");
            Console.WriteLine("4 - Divisão ( / )");
            Console.WriteLine("Digite o número da operação: ");
            int operation = Convert.ToInt32(Console.ReadLine ());

            double result = 0;

            //Condições
            if (operation == 1)
            {
                result = num1 + num2;
            }
            else if (operation == 2)
            {
                result = num1 - num2;
            }
            else if (operation == 3)
            {
                result = num1 * num2;
            }
            else if (operation == 4)
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");

                }
            }
            else 
            {
                Console.WriteLine("Operação inválida. por favor, escolha uma");
            }

            //Exibir resultado
            Console.WriteLine ("\nO resultado da operação "+ operation + " com os valores do primeiro numero " + num1 + " e do segundo numero " + num2 + " é: " + result + "\n");

            Console.WriteLine ("\nDeseja realizar outra operação (s/n): " );
            string response = Console.ReadLine();

            if (response != "s")
            {
                varContinue = false;
            }
        }
        Console.WriteLine("\nEncerrando a calculadora. Obrigado por usar!");
    }
}
