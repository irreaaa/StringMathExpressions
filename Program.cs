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
    string[] strings = expression.Split('+','-');
    string[] result = new string[strings.Length];

    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length == 1)
        {
            result[i] = strings[i];
        }
        else
        {
            string[] split = strings[i].Split('*', '/');
            List<string> znaki = new List<string>();
            for (int k = 0; k < strings[i].Length; k++)
            {
                if (strings[i][k] == '*' || strings[i][k] == '/')
                {
                    znaki.Add(strings[i][k].ToString());
                }
            }

            double result1 = double.Parse(split[0]);
            for (int j = 1; j < split.Length; j++)
            {
                if (znaki[j - 1] == "*")
                {
                    result1 *= double.Parse(split[j]);
                }
                if (znaki[j - 1] == "/")
                {
                    result1 /= double.Parse(split[j]);
                }
            }
            result[i] = result1.ToString();
        }
    }

    double j1 = double.Parse(result[0]);
    List<string> znaki1 = new List<string>();
    for (int i = 0; i < expression.Length; i++)
    {
        if (expression[i] == '+' || expression[i] == '-')
        {
            znaki1.Add(expression[i].ToString());
        }
    }

    for (int i = 1; i < result.Length; i++)
    {
        if (znaki1[i - 1] == "+")
        {
            j1 += double.Parse(result[i]);
        }
        if (znaki1[i - 1] == "-")
        {
            j1 -= double.Parse(result[i]);
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
