Console.WriteLine($"Indtast et tal mellem 1 og {int.MaxValue}.");
var value = Console.ReadLine(); // Using var since user might enter anything.
bool test = int.TryParse(value, out int result);
if (test && result <= int.MaxValue && result > 0)
{
    for (int i = 1; i <= result; i++)
    {
        string output = "";
        if (i % 3 == 0)
        {
            output += "Fizz";
        }
        if (i % 5 == 0)
        {
            output += "Buzz";
        }
        if (i % 7 == 0)
        {
            output += "Jazz";
        }
        if (output != "") Console.WriteLine(output);
    }
}
else
{
    Console.WriteLine("Hvad har du gang i?!");
}