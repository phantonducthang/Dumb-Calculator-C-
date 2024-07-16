// See https://aka.ms/new-console-template for more information

namespace toturial;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Calculator Program!");
        Console.WriteLine("Can't slove the Maths? We can do it for you");
        var a = Console.ReadLine();
        if (a == "+")
        {
            Console.WriteLine("Enter your First Number");
            var num1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Second Number");
            var num2 = Convert.ToInt64(Console.ReadLine());
            var ans = num1 + num2;
            Console.WriteLine("The Answer is: "+ ans);
        }
        else if (a == "-")
        {
            Console.WriteLine("Enter your First Number");
            var num3 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Second Number");
            var num4 = Convert.ToInt64(Console.ReadLine());
            var ans1 = num3 - num4;
            Console.WriteLine("The Answer is: "+ ans1);
        }
        else
        {
            Console.WriteLine("Sorry! We don't support this. Only use + or -");
        }
        Console.WriteLine("Do You Want to Continue? (Yes/No)");
        string? yourAnswer = Convert.ToString(Console.ReadLine());
        if (yourAnswer == "Yes")
        {
            Console.WriteLine("What type do you want to use? (1/2)");
            Console.WriteLine("1 is for + / -");
            Console.WriteLine("2 is for * / : ");
        }
        var tokoca = Convert.ToInt64(Console.ReadLine());
        if (tokoca == 1)
        {
            Console.WriteLine("+ or - ?");
            
        } 
    }
}