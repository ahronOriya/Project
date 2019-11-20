using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, double> factMap = new Dictionary<char, double>();
            Dictionary<char, int> result = new Dictionary<char, int>();
            setMap(factMap);
            Console.WriteLine("Hello World!");
            int sign = 65;
            int sum = 0;
            string myStr= "JGRMQOYGHMVBJWRWQFPWHGFFDQGFPFZRKBEEBJIZQQOCIBZKLFAFGQVFZFWWEOGWOPFGFHWOLPHLRLOLFDMFGQWBLWBWQOLKFWBYLBLYLFSFLJGRMQBOLWJVFPFWQVHQWFFPQOQVFPQOCFPOGFWFJIGFQVHLHLROQVFGWJVFPFOLFHGQVQVFILEOGQILHQFQGIQVVOSFAFGBWQVHQWIJVWJVFPFWHGFIWIHZZRQGBABHZQOCGFHX";
            for (int i = 0; i < 26; i++)
            {
                foreach (char c in myStr)
                {
                    if (c == (char)sign) sum += 1;
                }
                //Console.WriteLine((char)sign+" "+sum);
                result.Add((char)sign, sum);
                sum = 0;
                sign += 1;
            }
            Dictionary<char, char> switched= checkAdaption(factMap, result);
            string str = "";
            for(int j=0;j<myStr.Length;j++)
            {
                char e = switched[myStr[j]];
                str += e;
            }
            Console.WriteLine(str);
        }

        private static Dictionary<char, char> checkAdaption(Dictionary<char, double> factMap, Dictionary<char, int> result)
        {
            Dictionary<char, char> switched = new Dictionary<char, char>();
            while (factMap.Count > 0)
            {
                KeyValuePair<char, double> maxResult = factMap.OrderByDescending(item => item.Value).First();
                KeyValuePair<char, int> maxFound = result.OrderByDescending(item => item.Value).First();
                switched.Add( maxFound.Key, maxResult.Key);
                factMap.Remove(maxResult.Key);
                result.Remove(maxFound.Key);
            }
            return switched;
        }

        private static void setMap(Dictionary<char, double> factMap)
        {
            factMap.Add('A', 20.008);
            factMap.Add('B', 3.66);
            factMap.Add('C', 6.832);
            factMap.Add('D', 10.248);
            factMap.Add('E', 30.488);
            factMap.Add('F', 5.368);
            factMap.Add('G', 4.88);
            factMap.Add('H', 14.884);
            factMap.Add('I', 17.08);
            factMap.Add('J', 0.244);
            factMap.Add('K', 1.952);
            factMap.Add('L', 9.76);
            factMap.Add('M', 5.856);
            factMap.Add('N', 16.348);
            factMap.Add('O', 8.3);
            factMap.Add('P', 4.636);
            factMap.Add('Q', 0.244);
            factMap.Add('R', 14.64);
            factMap.Add('S', 15.372);
            factMap.Add('T', 21.96);
            factMap.Add('U', 6.832);
            factMap.Add('V', 2.44);
            factMap.Add('W', 5.856);
            factMap.Add('X', 4.88);
            factMap.Add('Y', 0.245);
            factMap.Add('Z', 0.244);
        }
    }
}
