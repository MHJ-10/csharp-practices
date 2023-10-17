namespace PracticeFour
{
    public class Financial

    {
        public Bank _bank { get; set; }

        public Financial(Bank bank)
        {
            _bank = bank;
        }
        public void Despoit(float amount)
        {
            _bank.Balance += amount;
        }

        public void Withdraw(float amount)
        {
            _bank.Balance -= amount;

        }
    }

}


