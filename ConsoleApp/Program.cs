
namespace Aula01;

public class Program 
{ 
    public static void Main() 
    { 
        Console.WriteLine("-----Cadastro de usuario-----");
        Console.Write("Digite o seu nome: ");
        string name = Console.ReadLine();


        Console.WriteLine("Digite sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Seu nome é " + name + "Sua idade é: " + age);
    }

}
