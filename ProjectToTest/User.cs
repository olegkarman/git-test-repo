namespace ProjectToTest
{
    internal enum UserGender
    {
        Male,
        Female,
        Unknown
    }
    internal class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; }
        public UserGender Gender { get; set; }

        public User()
        {
        
        }
        public User(int age)
        {
            Age = age;
        }

        public override string ToString()
        {
            var ageString = Age < 10 ? "I am a baby" : $"I am {Age} years old";
            return $"Hi, my name is {FirstName} and last name {LastName}. {ageString}. I am {Gender}.";
        }
    }
}
