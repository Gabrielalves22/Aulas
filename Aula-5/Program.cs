namespace Aula_5;

public class program
{
    public static void Main()
    {
        // operadores aritmétrico

        Console.WriteLine ("======== CALCULADORA ========");
        Console.WriteLine ("Digite o primeiro numero: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("Digite o segundo numero: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("==============================");

        // adição
        int sum = number1 + number2;
        Console.WriteLine ("A soma dos numeros é: " + sum);

        //subtração
        int substraction = number2 - number1;
        Console.WriteLine ("A subtração dos numeros é: " + substraction);

        //multiplicação
        int multiplication = number1 * number2;
        Console.WriteLine ("A multiplicação dos numeros é: " + multiplication);

        //divisão
        int division = number2 / number1;
        Console.WriteLine ("A divisão dos numeros é: " + division);

        //modulo
        int module = number2 % number1;
        Console.WriteLine ("O módulo dos numeros é: " + module);
        
    }
}
