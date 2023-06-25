using System;
using System.Collections.Generic;

Console.Write("Enter a string that you wisho to be reverted: ");
string userInput = Console.ReadLine();
Console.WriteLine($"Here is the reverted string: {ReverseString(userInput)}");

string ReverseString(string userInput)
{
    List<char> chars= new List<char>();
    foreach (char ch in  userInput)
    {
        chars.Add(ch);
    }
    chars.Reverse();
    string res = String.Join("", chars);
    return res;
}
