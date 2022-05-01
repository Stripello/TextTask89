using TextTask89;
using System.Net;
/*
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

Console.WriteLine(TextOperation.Delatation(text,length));
*/

//Console.WriteLine(Numbers.NameSomeNumber());

for (int i = 0; i < 1000; i++)
{
    var hindu = Numbers.NameSomeNumbersHinduEdition(i);
    var russian = Numbers.NameSomeNumber(i);
    if (!string.Equals(hindu, russian))
    {
        Console.WriteLine(hindu + "    " + russian);
    }
   Thread.Sleep(200);
}
