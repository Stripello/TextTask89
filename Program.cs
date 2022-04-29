using TextTask89;

Console.WriteLine("Please, enter text to process.");
var text = Console.ReadLine();

var searchedPosition = TextOperation.PositionOfFalseBracket(text);

if (searchedPosition == -1)
{
    Console.WriteLine("There is no false bracket in text.");
}
else
{
    Console.WriteLine($"Position of false bracket in text = {searchedPosition}");
}

