
namespace FinalProject
{
    class User
    {
        public string userName, firstName, lastName, email, phoneNumber;
        public User(string userName, string _firstName, string _lastName, string _email, string _phoneNumber)
        {
            this.userName   = userName;
            firstName       = _firstName;
            lastName        = _lastName;
            email           = _email;
            phoneNumber     = _phoneNumber;
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