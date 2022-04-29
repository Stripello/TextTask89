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
            var answer = new StringBuilder();
            var 


            return answer.ToString();
        }
    }

}
