using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace TextTask89
{
    internal static class Numbers
    {
        internal static int AskNumber()
        {
            int answer;
            while (true)
            {
                Console.WriteLine("Please, enter integer between 0 and 1000");
                if (int.TryParse(Console.ReadLine(), out answer) && answer <= 1000 && answer >= 0)
                {
                    return answer;
                }
                else
                {
                    Console.WriteLine("Entered string doesn't fit conditions.");
                }
            }
        }
        internal static string NameSomeNumbersHinduEdition(int numberToName)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("https://numeralonline.ru/" + numberToName);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();
            var begin = result.IndexOf("словами ");
            var end = result.IndexOf('.');
            return result[(begin + 10)..end];
        }
        internal static string NameSomeNumber(int numberToName)
        {
            var answer = new StringBuilder();
            switch (numberToName/100)
            {
                case 10:
                    return "одна тысяча";
                case 9:
                    answer.Append("девятьсот ");
                    break;
                case 8:
                    answer.Append("восемьсот ");
                    break;
                case 7:
                    answer.Append("семьсот ");
                    break;
                case 6:
                    answer.Append("шестьсот ");
                    break;
                case 5:
                    answer.Append("пятьсот ");
                    break;
                case 4:
                    answer.Append("честыреста ");
                    break;
                case 3:
                    answer.Append("триста ");
                    break;
                case 2:
                    answer.Append("двести ");
                    break;
                case 1:
                    answer.Append("сто ");
                    break;
            }

            numberToName -= numberToName / 100 * 100;
            if ( numberToName <= 19 )
            {
                switch (numberToName%10)
                {
                    case 9:
                        answer.Append("девят");
                        break;
                    case 8:
                        answer.Append("восем");
                        break;
                    case 7:
                        answer.Append("сем");
                        break;
                    case 6:
                        answer.Append("шест");
                        break;
                    case 5:
                        answer.Append("пят");
                        break;
                    case 4:
                        answer.Append("четыр");
                        break;
                    case 3:
                        answer.Append("три");
                        break;
                    case 2:
                        answer.Append("две");
                        break;
                    case 1:
                        answer.Append("оди");
                        break;
                }
                answer.Append("надцать");
                return answer.ToString();
            }
            else
            {
                switch ( numberToName/10 )
                {
                    case 9:
                        answer.Append("девяносто ");
                        break;
                    case 8:
                        answer.Append("восемьдесят ");
                        break;
                    case 7:
                        answer.Append("семьдесят ");
                        break;
                    case 6:
                        answer.Append("шестьдесят ");
                        break;
                    case 5:
                        answer.Append("пятьдесят ");
                        break;
                    case 4:
                        answer.Append("сорок ");
                        break;
                    case 3:
                        answer.Append("тридцать ");
                        break;
                    case 2:
                        answer.Append("двадцать ");
                        break;
                }
                numberToName -= numberToName / 10 * 10;
                switch (numberToName)
                {
                    case 9:
                        answer.Append("девять");
                        break;
                    case 8:
                        answer.Append("восемь");
                        break;
                    case 7:
                        answer.Append("семь");
                        break;
                    case 6:
                        answer.Append("шесть");
                        break;
                    case 5:
                        answer.Append("пять");
                        break;
                    case 4:
                        answer.Append("четыре");
                        break;
                    case 3:
                        answer.Append("три");
                        break;
                    case 2:
                        answer.Append("два");
                        break;
                    case 1:
                        answer.Append("один");
                        break;
                }
                return answer.ToString();
            }
        }
    }
}
