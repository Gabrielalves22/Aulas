namespace Aula_9;

public class program
{
    public static void Main()
    {
        Console.WriteLine ("===== Oeradores Lógicos =====");

        bool isloggedIn = true;
        bool hasAminAcces = false;

        Console.WriteLine ("\ninformaçoes do usuario:");
        Console.WriteLine ("Usuario logado: " + isloggedIn);
        Console.WriteLine ("Acesso ao painel de administradores: " + hasAminAcces);

        Console.WriteLine ("\nPermissões");
        
        // Operador (||) - ou
        if (isloggedIn || hasAminAcces)
        {
            Console.WriteLine ("Acesso ao sistema Concedido!");
        }
        else
        {
            Console.WriteLine ("Acesso ao sistema Negado!");
        }

        // Operador (&&) - E
        if (isloggedIn && hasAminAcces)
        {
            Console.WriteLine ("Painel de Adimin Liberado!");
        }
        else
        {
            Console.WriteLine ("Acesso ao painel de administradores Negado!");
        }

        // Operador (!) - Negação
        if (!isloggedIn)
        {
            Console.WriteLine ("Usuário não está logado");
        }
        else
        {
            Console.WriteLine ("Usuário está logado");
        }

    }
}
