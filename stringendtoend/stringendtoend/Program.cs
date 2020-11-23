using System;
using System.Collections.Generic;
using System.Linq;

namespace stringendtoend
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "Yesthatssosaidsamandweshouldntbehereatallifwedknownmoreaboutitbeforewestartedbutisupposeitsoftenthatwaythebravethingsintheoldtalesandsongsmrfrodoadventuresasiusedtocallthemiusedtothinkthattheywerethingsthewonderfulfolkofthestorieswentoutandlookedforbecausetheywantedthembecausetheywereexcitingandlifewasabitdullakindofasportasyoumightsaybutthatsnotthewayofitwiththetalesthatreallymatteredortheonestharatstarayinthemindfolkseemtohavebeenjustlandedinthemusuallytheirpathswerelaidthatwayasyouputitbutiexpecttheyhadlotsofchanceslikeusofturningbackonlytheydidntandiftheyhadweshouldntknowbecausetheydhavebeenforgottenwehearaboutthoseasjustwentonandnotalltoagoodendmindyouatleastnottowhatfolkinsideastoryandnotoutsideitcallagoodendyouknowcominghomeandfindingsallrightthoughnotquitethesamelikeoldmrbilbobutthosearentalwaysthebesttalestohearthoughtheymaybethebesttalestogetlandediniwonderwhatsortofatalewevefalleninto "; //eyedipadanadapideye
            int counter = 0;
            List<string> palindromeList = new List<string>();

            for (int i = 0; i < paragraph.Length - 1; i++)
            {
                for (int j = 0; j < paragraph.Length - i; j++)
                {
                    string first = paragraph.Substring(i, j);
                    var second = first.ToCharArray();
                    Array.Reverse(second);
                    if (new string(second) == first)
                    {
                        palindromeList.Add(first);
                    }
                }
            }

            var longestTerm = palindromeList
            .GroupBy(str => str == null ? 0 : str.Length)
            .OrderByDescending(g => g.Key) // order by length
            .First();
            Console.WriteLine(longestTerm.First());

        }
    }
}
