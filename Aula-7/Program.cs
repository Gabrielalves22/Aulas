namespace Aula_6;

public class program
{
    public static void Main()
    {
        //Operadores de atribuição
        Console.WriteLine ("=== Operadores de Atribuição ===");

        //inicializar variavel
        int x = 10;
        Console.WriteLine ("\nValor inicial da Vareavel: " + x);

        //Operador de atribuição simplis (=)
        x = 20;
        Console. WriteLine ("\nAtibuição simplis (=)");
        Console.WriteLine ("Valor após atribuição: " + x);

        //Atribuição composta (incremento) (++)
        x++;//Equivale a x = x + 1

        Console.WriteLine ("\nAtribuição Composta Incremento (++)");
        Console.WriteLine ("Novo valor de X: " + x);

        //Atribuição composta (+=)
        x += 10; // Equivale a x = x + 10
        Console.WriteLine ("\nAtribuição composta (+=)");
        Console.WriteLine ("Novo valor de X: " + x);

        //Atribuição composta (-=)
        x -= 10; // Equivale a x = x - 10
        Console.WriteLine ("\nAtribuição composta (-=)");
        Console.WriteLine ("Novo valor de X: " + x);

        //Atribuição composta (*=)
        x *= 10; // Equivale a x = x * 10
        Console.WriteLine ("\nAtribuição composta (*=)");
        Console.WriteLine ("Novo valor de X: " + x);

        //Atribuição composta (/=)
        x /= 10; // Equivale a x = x / 10
        Console.WriteLine ("\nAtribuição composta (/=)");
        Console.WriteLine ("Novo valor de X: " + x);
        
    }
}
