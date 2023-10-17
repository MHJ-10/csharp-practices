namespace PracticeFour
{
    public class HR
    {
        public List<Employee> Employees { get; set; }

        public HR()
        {
            Employees = new List<Employee>();
        }


        public void Hire(params Employee[] NewEmployees)
        {
            foreach (Employee employee in NewEmployees)
            {
                Employees.Add(employee);
            }
        }

        public void Fire(params int[] ids)
        {

            foreach (int id in ids)
            {
                Employees.RemoveAll(employee => employee.Id == id);
            }
        }

        public void PrintEmployeesList()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"Full Name: {employee.FullName}");
                Console.WriteLine($"Account Number: {employee.AccountNumber}");
                Console.WriteLine($"Hire Date: {employee.HireDate.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Account Balance: {employee.Balance.ToString("C")}");
                Console.WriteLine();
            }
        }

    }

}


