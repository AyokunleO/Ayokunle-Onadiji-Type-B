namespace Question3
{
    public class Employee : Person, IPayable
    {
        private decimal salary;
        public string MailingAddress { get; set; }
        public Employee(string fName, string lName, decimal salary, string mail):base(fName, lName)
        {
            Salary = salary;
            MailingAddress = mail;
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public decimal RetrieveAmount()
        {
            
        }


        
    }
}