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
    }
}
