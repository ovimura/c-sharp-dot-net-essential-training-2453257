// See https://aka.ms/new-console-template for more information

using System;

string exit = "exit";
string input = "";
DateTime today = DateTime.Today;

do
{
    Console.WriteLine("Which date? (or 'exit')");
    input = Console.ReadLine();
    DateTime dt;
    if(DateTime.TryParse(input, out dt)) {
        if(dt == today) {
            Console.WriteLine($"That is today, {dt.ToString("dd MMM yyyy")}");
        } else if (dt > today) {
            Console.WriteLine($"That is in the future, {(dt-today).Days} days.");
        } else if(dt < today) {
            Console.WriteLine($"That is in the past, {(today-dt).Days} days.");
        }
    } else if (input != exit) {
        Console.WriteLine("That doesn't seem to be a valid date");
    }
} while (input != exit);