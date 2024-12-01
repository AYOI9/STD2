using System;
using System.Text.RegularExpressions;


        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();
        string result = Regex.Replace(input, "[a-zA-Z]", "");
        Console.WriteLine(result);
    