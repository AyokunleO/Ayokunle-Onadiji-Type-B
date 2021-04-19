using System;
namespace Question1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public DateTime DateOfBirth { get; set; }
        private bool adult;
        public bool Adult
        {
            get { return adult; }
            set { adult = value; }
        }
        

        public Person(string fName, string lName, string email, DateTime dateOB)
        {
            FirstName = fName;
            LastName = lName;
            EmailId = email;
            DateOfBirth = dateOB;
        }
        public Person(string fName, string lName, string email)
        {
            FirstName = fName;
            LastName = lName;
            EmailId = email;
        }
        public Person(string fName, string lName, DateTime dateOB)
        {
            FirstName = fName;
            LastName = lName;
            DateOfBirth = dateOB; 
        }

        public void Adult()
        {
            if((DateOfBirth.Year - 18)>= 0)
            {
                Console.WriteLine("Adult");
            }else{
                Console.WriteLine("Not Adult!");
            }
        }
        public void Birthday()
        {
            if (DateOfBirth.Year != DateTime.Now.Year && DateOfBirth.Month == DateTime.Now.Month && DateOfBirth.Day == DateTime.Now.Day)
            {
                Console.WriteLine("Today is your birthday!");
            }else{
                Console.WriteLine("Not your birthday!");
            }
        }
        public void screenName()
        {
            Console.WriteLine(FirstName + DateOfBirth.year);
        }

    }
}