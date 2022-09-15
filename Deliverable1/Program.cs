
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

string restart;
do
{
    do
    {

        Console.WriteLine("How many people are we making PB&J sandwiches for?");
        int people = int.Parse(Console.ReadLine());

        decimal slices = (people * 2);

        decimal tablespoons = (people * 2);

        decimal teaspoons = (people * 4);

        decimal loaves = (slices / 28);
        decimal l = Math.Round(loaves, 0, MidpointRounding.ToPositiveInfinity);

        decimal pbjars = Math.Ceiling((decimal)(tablespoons / 32));
        decimal pb = Math.Round(pbjars, 0, MidpointRounding.ToPositiveInfinity);

        decimal jjars = Math.Ceiling((decimal)(teaspoons / 48));
        decimal j = Math.Round(jjars, 0, MidpointRounding.ToPositiveInfinity);

        Console.WriteLine("You Need:");
        Console.WriteLine(slices + " slices of bread");
        Console.WriteLine(tablespoons + " tablespoons of peanut butter");
        Console.WriteLine(teaspoons + " teaspoons of jelly");
        Console.WriteLine("");
        Console.WriteLine("which is...");
        Console.WriteLine("");
        Console.WriteLine(l + " loaves of bread");
        Console.WriteLine(pb + " jars of peanut butter");
        Console.WriteLine(j + " jars of jelly");
        Console.WriteLine("");
        Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");

        restart = Console.ReadLine();
    }
    while (restart == "yes");
}
while (restart == "y");

Console.WriteLine("Goodbye!");
 

  

