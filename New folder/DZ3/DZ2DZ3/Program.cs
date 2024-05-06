using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace DZ2DZ3
{
    public class Program
    {
        public enum Gender
        {
            male,
            female,
            undefined
        }
        static void Main(string[] args)
        {
            User user1 = new User();
            // user1.Gender = Gender.Male;
            try
            {
                while (true)
                {
                    Console.WriteLine(" Pleace input your name");
                    user1.FirstName = Console.ReadLine();

                    if (Regex.IsMatch(user1.FirstName, "^[a-zA-Z]+$"))
                    {
                        user1.FirstName = user1.FirstName;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid first name! Please enter only letters.");
                    }
                }
                    Console.WriteLine(" Pleace input your surname");
                    user1.LastName = Console.ReadLine();
                
            }
            catch
            {
                Console.WriteLine("You entered unkorect value.");
            }
          user1.Name();
        }
    }
}
