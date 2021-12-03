/* >>> CLASSE ACCOUNT <<< */
namespace Aula129_Sealed.Entities
{
    class Account
    {
        public int Number { get; private set; } // Private nao permite alteracao da variavel, somente acesso
        public string Holder { get; private set; }
        public double Balance { get; protected set; } // Protected permite alteracao dentro da Classe e suas Subclasses

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) // VIRTUAL permite a sobreposicao pelo OVERRIDE
        {
            Balance -= amount + 5.0; // Taxa de 5.0 para cada saque da conta-corrente
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
