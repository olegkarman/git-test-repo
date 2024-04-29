using System.Reflection;

namespace ProjectToTest
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public User(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public override string ToString()
        {
            return $"Hi, my name is {FirstName} and last name {LastName}. I am {Age} years old.";
        }
    }
}
