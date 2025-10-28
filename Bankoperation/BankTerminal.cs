namespace Bankoperation
{
    internal class BankTerminal
    {
        //Instancia da classe BnakOperations
        BanksOperations bank = new BanksOperations();

        public void Start()
        {
            var inExecution = true;

            while (inExecution)
            {
                DisplayMenu();
                string option = Console.ReadLine();

                if (option == "1")
                {
                    bank.CheckBalance();
                }
                else if (option == "2")
                {
                    bank.Deposit();
                }
                else if (option == "3")
                {
                    bank.WithDraw();
                }
                else if (option == "4")
                {
                    inExecution = false;
                    Console.WriteLine("Obrigado por usar o Terminal Bancário. Até logo!");
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                };
                
            };
        }


        public void DisplayMenu()
        {
            Console.WriteLine("Bem-vindo ao Terminal Bancário!");
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1. Verificar Saldo");
            Console.WriteLine("2. Deposito");
            Console.WriteLine("3. Saque");
            Console.WriteLine("4. Sair");
        }
    }
}
