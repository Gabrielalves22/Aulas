namespace Aula_3;

public class program
{
    public static void Main()
    {
        // inoput e outinput
        Console.WriteLine ("--------- CADASTRO DE USUÁRIOS --------");

        //solicitar o nome do usuário
        Console.WriteLine ("Digite seu nome: ");
        string name = Console.ReadLine();

        //solicitação da idade do usuário
        Console.WriteLine ("Digite sua Idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("---------------------------------------");

        Console.WriteLine ("O nome de usuário é: " + name);
        Console.WriteLine ("A idade do usuário é: " + age);

    }
}
