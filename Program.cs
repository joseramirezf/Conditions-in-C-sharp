Console.WriteLine("C# Conditions");

Console.WriteLine("Enter student grade");
double grade = Double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Did student pay? (y/n)");

//bool paid = (Console.ReadLine() == "y");
bool paid;
string input = Console.ReadLine() ?? "n";
if (input == "y")
{
    paid = true;
} else {
    paid = false;
}

if (grade >= 70)
{
    if (paid)
    {
        Console.WriteLine("Congratulations!");
    } else {
        Console.WriteLine("You need to pay graduations fees");
    }
} else {
    Console.WriteLine ("Did not graduate");
}
Console.WriteLine("Program ended!");