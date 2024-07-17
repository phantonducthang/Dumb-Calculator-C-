﻿// See https://aka.ms/new-console-template for more information

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

    Console.WriteLine(userAns == "1" ? "You choose 1" : "Are you Dumb?");
  }
}