﻿using System;

namespace snallWeeks_lab_firstDotNetApp
{
  class Program
  {
    public static string Greet(string name)
    {
      return "Welcome to SALT, " + name;
    }
    static void Main(string[] args)
    {
      Console.Write("What is your name? ");
      var name = Console.ReadLine();

      var greeting = Greet(name);

      Console.WriteLine(greeting);
    }
  }
}
