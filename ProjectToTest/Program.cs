using ProjectToTest;
using System.Reflection;
using System.Text.RegularExpressions;

internal class Program
{
    public static bool IsValidName(string name = "")
    {
        Regex regex = new Regex(@"^[A-Za-z]+$");
        return !string.IsNullOrWhiteSpace(name) && regex.IsMatch(name);
    }
    public static User createUser()
    {
        Random random = new Random();
        ushort randomAge = (ushort)random.Next(1, 101);
        var user1 = new User(randomAge);

        Console.WriteLine("Enter the first name of the user:");
        while (true)
        {
            var firstName = Console.ReadLine();
            if (IsValidName(firstName))
            {
                user1.FirstName = firstName;
                break;
            }
            else
            {
                Console.WriteLine("Wrong format. Please, enter a proper name:");
            }
        }

        Console.WriteLine("Enter the last name of the user:");
        while (true)
        {
            var lastName = Console.ReadLine();
            if (IsValidName(lastName))
            {
                user1.LastName = lastName;
                break;
            }
            else
            {
                Console.WriteLine("Wrong format. Please, enter a proper last name:");
            }
        }

        Console.WriteLine("Select a user's gender (0 - Male, 1 - Female, 2 - Unknown):");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int genderInput) && Enum.IsDefined(typeof(UserGender), genderInput))
            {
                user1.Gender = (UserGender)genderInput;
                break;
            }
            else
            {
                Console.WriteLine("Wrong format. Please, try again (0 - Male, 1 - Female, 2 - Unknown):");
            }
        }

        Console.WriteLine(user1.ToString());

        return user1;
    }

    public static void Main ()
    {
        createUser();
    }
}