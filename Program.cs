// See https://aka.ms/new-console-template for more information

namespace toturial;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Dumb Calc!");
        Console.WriteLine("What do you want to do today?");
        Console.WriteLine("Choose one option:");

        Ask option = new Ask();
        Console.WriteLine(option.Addition);
        Console.WriteLine(option.Subtraction);
        Console.WriteLine(option.Multiplication);
        Console.WriteLine(option.Division);

        var userAns = Console.ReadLine();

        switch (userAns)
        {
            case "1":
                Ask enter = new Ask();
                Console.WriteLine("You choose Addition!");
                Console.WriteLine(enter.EnNum1);
                var num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(enter.EnNum2);
                var num2 = Convert.ToInt32(Console.ReadLine());
                var ans1 = num1 + num2;
                Console.WriteLine("The answer is " + ans1);
                break;

            case "2":
                Ask enter2 = new Ask();
                Console.WriteLine("You choose Subtraction!");
                Console.WriteLine(enter2.EnNum1);
                var num3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(enter2.EnNum2);
                var num4 = Convert.ToInt32(Console.ReadLine());
                var ans2 = num3 - num4;
                Console.WriteLine("The answer is " + ans2);
                break;

            case "3":
                Ask enter3 = new Ask();
                Console.WriteLine("You choose Subtraction!");
                Console.WriteLine(enter3.EnNum1);
                var num5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(enter3.EnNum2);
                var num6 = Convert.ToInt32(Console.ReadLine());
                var ans3 = num6 * num5;
                Console.WriteLine("The answer is " + ans3);
                break;

            case "4":
                Ask enter4 = new Ask();
                Console.WriteLine("You choose Subtraction!");
                Console.WriteLine(enter4.EnNum1);
                var num7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(enter4.EnNum2);
                var num8 = Convert.ToInt32(Console.ReadLine());
                var ans4 = num7 / num8;
                Console.WriteLine("The answer is " + ans4);
                break;

                default:
                    Console.WriteLine("That's not a valid selection");
                    break;
        }
    }
}
