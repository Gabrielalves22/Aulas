namespace Aula_5;

public class program
{
    public static void Main()
    {
        // if e else
        Console.WriteLine ("====== Verificador de numeros inpares e pares ======");

        Console.WriteLine ("Digite um numero: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = number % 2;

        if (result == 0)
        {
            Console.WriteLine ("O numero é par!");
        }
        else
        {
            Console.WriteLine ("O numero é impar!");
        }
        

        Console.WriteLine ("====================================================");
    }
}
