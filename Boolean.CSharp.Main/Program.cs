// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string s = new System.Text.StringBuilder().Insert(0, "Hello"+",", 5).ToString();

Console.WriteLine(s.Remove(s.Length-1));