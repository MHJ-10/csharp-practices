namespace PracticeFour
{
    class Program
    {
        static void Main(string[] args)
        {
            HR hr = new HR();

            Bank bank = new Bank(5000, hr);

            Financial financial = new Financial(bank);


            Employee employeeOne = new Employee
            {
                Id = 1,
                FullName = "Parsa Hejazi",
                AccountNumber = "2853",
                HireDate = new DateTime(2019, 5, 12),
                Balance = 500,
            };

            Employee employeeTwo = new Employee
            {
                Id = 2,
                FullName = "Sina Mohammadi",
                AccountNumber = "4562",
                HireDate = new DateTime(2023, 12, 27),
                Balance = 630,
            };

            Employee employeeThree = new Employee
            {
                Id = 3,
                FullName = "Rasoul Jamshidi",
                AccountNumber = "6921",
                HireDate = new DateTime(2016, 4, 18),
                Balance = 480,
            };


            hr.Hire(employeeOne, employeeTwo, employeeThree);

            hr.Fire(2);

            financial.Despoit(1400);
            financial.Withdraw(500);


            bank.Payment("2853", 5100);
            bank.Payment("6921", 500);


            hr.PrintEmployeesList();
        }
    }
}
