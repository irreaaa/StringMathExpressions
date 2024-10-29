using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
//StreamWriter vvod = new StreamWriter("C:/Users/irisp/source/repos/StringsMathExpressions/StringsMathExpressions/vvod.txt");
Console.WriteLine("Введите математическое выражение: ");
string expression = Console.ReadLine();
//vvod.Close();
//StreamWriter vyvod = new StreamWriter("C:/Users/irisp/source/repos/StringsMathExpressions/StringsMathExpressions/vyvod.txt");
//StreamReader vvod1 = new StreamReader("C:/Users/irisp/source/repos/StringsMathExpressions/StringsMathExpressions/vvod1.txt");
try
{
    expression = expression.Replace(" ", "");
    string[] strings = expression.Split(new Char[] { '+', '-' });
    //Console.WriteLine("[{0}]", string.Join(", ", strings));
    string[] result = new string[strings.Length];

    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length == 1)
        {
            result[i] = strings[i];
        }
        else
        {
            string[] split = strings[i].Split(new Char[] { '*', '/' });
            List<string> znaki = new List<string>();
            foreach (string znak in strings)
            {
                if (znak == "+" || znak == "-")
                {
                    znaki.Add(znak);
                }
            }

            double result1 = double.Parse(split[0]);
            for (int j = 1; j < znaki.Count() + 1; j++)
            {
                if (strings[i].Length == 1)
                {
                    result[i] = strings[i];
                    break;
                }
                if (znaki[j - 1] == "*")
                {
                    result[i] = (result1 * double.Parse(split[j])).ToString();
                    result1 = result1 * double.Parse(split[j]);
                }
                if (znaki[j - 1] == "/")
                {
                    result[i] = (result1 / double.Parse(split[j])).ToString();
                    result1 = result1 / double.Parse(split[j]);
                }
            }
            result[i] = result1.ToString();
        }
    }

    double j1 = double.Parse(result[0]);
    List<string> znaki1 = new List<string>();
    foreach (string znak in strings)
    {
        if (znak == "+" || znak == "-")
        {
            znaki1.Add(znak);
        }
    }
    for (int i = 1; i < result.Length; i++)
    {
        if (znaki1[i - 1] == "+")
        {
            j1 = j1 + double.Parse(result[i]);
        }
        if (znaki1[i - 1] == "-")
        {
            j1 = j1 - double.Parse(result[i]);
        }
    }
    Console.WriteLine($"Результат: {j1}");

    //vyvod.Close();
    //vvod1.Close();
}
catch (Exception ex)
{
    Console.WriteLine("ошибка");
}

Console.ReadKey();
