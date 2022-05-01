using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTask89
{
    internal static class TextOperation
    {
        internal static int PositionOfFalseBracket(string text)
        {
            var bracketCounter = 0; ;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    bracketCounter++;
                }
                if (text[i] == ')')
                {
                    bracketCounter--;
                }
                if (bracketCounter < 0)
                {
                    return i;
                }
            }
            return -1;
        }

        internal static string Delatation(string text, int neededLength)
        {
            var splitedText = text.Split(' ').ToList(); //really want to concatinate this and next string of code
            splitedText.RemoveAll(x => x == string.Empty); 
            var length = -1;  //to remove whitespace counted after all strings
            foreach (var element in splitedText)
            {
                length += element.Length+1;
            }
            if (length > neededLength)
            {
                return "Asked text length less then original text length.";
            }
            var amountOfWords = splitedText.Count();
            var answer = new StringBuilder();
            if (amountOfWords <= 1)
            {
                answer.Append(string.Empty.PadRight((int)Math.Ceiling( ((double)neededLength - length )/ 2),' '));
                if (splitedText.Count ==1) //pretty sure there is more fitted way to do this
                {
                    answer.Append(splitedText[0]);
                }
                answer.Append(string.Empty.PadRight( (neededLength-length)/2 ));
                return answer.ToString();
            }
            else
            {
                var standartWhitespace = string.Empty.PadRight( (neededLength - length)/(amountOfWords-1) , ' ' );
                var amountOfWhidedWitespaces = neededLength - (neededLength - length) / (amountOfWords - 1) * (amountOfWords - 1);
                for (int i = 0; i < amountOfWords; i++)
                {
                    answer.Append(splitedText[i]);
                    answer.Append(standartWhitespace);
                    if (amountOfWhidedWitespaces > 0)
                    {
                        answer.Append(' ');
                    }
                    amountOfWhidedWitespaces--;
                }
                return answer.ToString();
            }
        }
    }

}
