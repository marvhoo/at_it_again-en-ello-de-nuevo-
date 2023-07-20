
namespace FinalProject
{
    class User
    {
        public string userName, firstName, lastName, email, phoneNumber;
        public User(string userName, string firstName, string lastName, string email, string phoneNumber)
        {
            this.userName        = userName;
            this.firstName       = firstName;
            this.lastName        = lastName;
            this.email           = email;
            this.phoneNumber     = phoneNumber;
        }

        public string Text()
        {
            string displayText = $"User:-----------{userName}-----------\n"
            + $"{lastName}, {firstName}.\nEmail: {email} \nphone number: {phoneNumber}"
            + "\n-----------------------------------";
            return displayText;
        }

        public void Display()
        {
            Console.WriteLine(Text());
        }


    }
}