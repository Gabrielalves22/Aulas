namespace Aula_8;

public class program
{
    public static void Main()
    {
        // Operadores Relacionais
        Console.WriteLine ("===== Operadores Relacionais ===== \n");
        Console.WriteLine ("Digite o primeiro numero (x): ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("Digite o segundo numero (y): ");
        int y = Convert.ToInt32(Console.ReadLine());

        string result;

        // Operador de igualdade (==)
        if (x == y)
        {
            result = x + " é igual a " + y;
        }
        else
        {
            result = x + " não é igual a " + y;
        }

        Console.WriteLine ("\nIgualdade (==): " + result);

        // Operador de desigualdade (!=)
        if (x != y)
        {
            result = x + " é diferente de " + y;
        }
        else
        {
            result = x + " é igual a " + y;
        }

        Console.WriteLine ("\nDesigualdade (!=): " + result);

        // Operador de maior que (>)
        if (x > y)
        {
            result = x + " é maior que " + y;
        }
        else
        {
            result = x + " não é maior que " + y;
        }

        Console.WriteLine ("\nMaior que (>): " + result);

        // Operador de menor que (<)
        if (x < y)
        {
            result = x + " é menor que " + y;
        }
        else
        {
            result = x + " não é menor que " + y;
        }

        Console.WriteLine ("\nMenor que (<): " + result);

        // Operador de maior ou igual a (>=)
        if (x >= y)
        {
            result = x + " é maior ou igual a " + y;
        }
        else
        {
            result = x + " não é maior ou igual a " + y;
        }
        Console.WriteLine ("\nMaior ou igual a (>=): " + result);

        // Operador de menor ou igual a (<=)
        if (x <= y)
        {
            result = x + " é menor ou igual a " + y;
        }
        else
        {
            result = x + " não é menor ou igual a " + y;
        }

        Console.WriteLine ("\nMenor ou igual a (<=): " + result);



    }
}
