namespace Question3
{
    public class Person : IPayable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private decimal amountDue;
        public decimal AmountDue
        {
            get { return amountDue; }
            set { 
                if(value > 0)
                {
                    amountDue = value;
                }
                }
        }
        public decimal RetrieveAmount()
        {
            return AmountDue;
        }
        

        public Person(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

    }
}