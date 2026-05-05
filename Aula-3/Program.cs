namespace Aula_3;

public class program
{
    public static void Main()
    {
        /* Execicio de variavel
        string name = "gabriel";

        name = "Paulo";

        Console.WriteLine ("A variávem tem como valor antigo: " + name);

        name = "Alana";
        Console.WriteLine ("A variávem tem como valor novo: " + name);
        */

        // constante

        // const
        const int number = 1000;

        Console.WriteLine ("O valor da constante é : " + number);

        // constante type var
        var variable = "gabriel";
        //variable = 200;

        Console.WriteLine ("O valor da varíavel é : " + variable);

        // cosntante type dynamic

        dynamic variable2 = 20;
        variable2 = "Gabriel";

        Console.WriteLine ("O valor da Variável é : " + variable2);
    }
}
