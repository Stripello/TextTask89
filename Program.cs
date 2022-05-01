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

int length;
while (true)
{
    Console.WriteLine("Please, enter neeeded text length.");
    if (int.TryParse(Console.ReadLine(), out length))
    {
        break;
    }
}
Console.WriteLine(TextOperation.Delatation(text, length));

var numberToName = Numbers.AskNumber();
Console.WriteLine(Numbers.NameSomeNumber(numberToName));