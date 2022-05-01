using System.Net;
using System.Text;

namespace TextTask89
{
    internal static class Numbers
    {
        internal static int AskNumber()
        {
            while (true)
            {
                Console.WriteLine("Please, enter integer between 0 and 1000");
                if (int.TryParse(Console.ReadLine(), out int answer) && answer <= 1000 && answer >= 0)
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
            if (numberToName == 0)
            {
                return "ноль";
            }
            var answer = new StringBuilder();
            switch (numberToName / 100)
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
                    answer.Append("четыреста ");
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
            if (numberToName <= 19)
            {
                switch (numberToName)
                {
                    case 19:
                        answer.Append("девятнадцать");
                        break;
                    case 18:
                        answer.Append("восемнадцать");
                        break;
                    case 17:
                        answer.Append("семнадцать");
                        break;
                    case 16:
                        answer.Append("шестнадцать");
                        break;
                    case 15:
                        answer.Append("пятнадцать");
                        break;
                    case 14:
                        answer.Append("четырнадцать");
                        break;
                    case 13:
                        answer.Append("тринадцать");
                        break;
                    case 12:
                        answer.Append("двенадцать");
                        break;
                    case 11:
                        answer.Append("одиннадцать");
                        break;
                    case 10:
                        answer.Append("десять");
                        break;
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
                return answer.ToString().Trim();
            }
            else
            {
                switch (numberToName / 10)
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
                return answer.ToString().Trim();
            }
        }
    }
}
