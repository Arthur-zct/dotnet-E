namespace Bankoperation
{
    internal class BanksOperations
    {
        decimal balance = 1000;

        public void CheckBalance()
        {
            Console.WriteLine($"Seu saldo é de: {balance}");
        }

        public void Deposit()
        {
            Console.WriteLine("Informe o valor a ser depositado: R$ ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Valor Inválido. Tente novamente");
            };
        }

        public void WithDraw()
        {
            Console.WriteLine("Informe o valor a ser retirado: R$ ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0) //verifica se o valor é válido, podendo ser escrito (zero)
            {
                if(amount <= balance)
                {
                    Console.WriteLine($"Valor de R$ {amount} retirado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para essa operação.");
                }
            }
            else
            {
                Console.WriteLine("Valor Inválido. Tente novamente");
            }
            ;
        }
    }
}
