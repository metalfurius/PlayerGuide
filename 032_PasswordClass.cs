Password pass = new Password();
while (true)
{
    Console.Write("Enter password: ");
    string input = Console.ReadLine();
    if (pass.IsValid(input))
    {
        Console.WriteLine("Password is valid.");
        break;
    }
    else
    {
        Console.WriteLine("Password is invalid. Please try again.");
    }
}

public class Password
{
    public bool IsValid(string pass)
    {
        if (pass.Length < 7 || pass.Length > 12)
        {
            return false;
        }

        bool hasUpper = false;
        bool hasLower = false;
        bool hasDigit = false;
        bool specialRequirement = false;

        foreach (char c in pass)
        {
            if (char.IsUpper(c)) hasUpper = true;
            else if (char.IsLower(c)) hasLower = true;
            else if (char.IsDigit(c)) hasDigit = true;
            else if (c == 'T' || c == '&') specialRequirement = true;
        }

        return hasUpper && hasLower && hasDigit && !specialRequirement;
    }
}