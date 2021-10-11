// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello From the console Phonebook App");
Console.WriteLine("Select operations");
Console.WriteLine("1 Add Contact");
Console.WriteLine("2 Display contact by number");
Console.WriteLine("3 View all contacts");
Console.WriteLine("$ Search for contacts for a given name");

var userinput = Console.ReadLine(); 

IServiceCollection 