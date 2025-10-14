
namespace Aula01;

public class Program 
{ 
    public static void Main() 
    {
        Console.WriteLine("====Verificador de numeros pares ou impares====");
        Console.WriteLine("Digite um numero: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int Result = number % 2;
        if (Result == 0)
        {
            Console.WriteLine("O numero " + number + " é par");
        }
        else
        {
            Console.WriteLine("O numero " + number + " é impar");
        }
    }

}
