namespace PracticeFour
{
    public class Bank
    {
        public float Balance { get; set; }
        public HR Hr { get; set; }

        public Bank(float initialBalance, HR hr)
        {
            Balance = initialBalance;
            Hr = hr;
        }


        public void Payment(string accountNumber, float amount)
        {
            Employee selectedEmployee = Hr.Employees.Find(e => e.AccountNumber == accountNumber);

            if (Balance >= amount)
            {
                selectedEmployee.Balance += amount;
                Balance -= amount;
            }
            else
            {
                throw new Exception("bank balance is not enough.");
            }

        }

    }

}


