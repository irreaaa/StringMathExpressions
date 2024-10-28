//using Microsoft.VisualBasic;
//using System;
//using System.Text;
//using static System.Net.Mime.MediaTypeNames;
////StreamWriter vvod = new StreamWriter("C:/Users/irisp/source/repos/StringsMathExpressions/StringsMathExpressions/vvod.txt");
//Console.WriteLine("Введите математическое выражение: ");
//string expression = Console.ReadLine();
////vvod.Close();
////StreamWriter vyvod = new StreamWriter("C:/Users/irisp/source/repos/StringsMathExpressions/StringsMathExpressions/vyvod.txt");
////StreamReader vvod1 = new StreamReader("C:/Users/irisp/source/repos/StringsMathExpressions/StringsMathExpressions/vvod1.txt");
//try
//{
//    expression = expression.Replace(" ", "");
//    char[] operators = "*/+-".ToCharArray();
//    char[] digitals = "0123456789".ToCharArray();
//    int[] priorities = new[] { 0, 0, 1, 1 };

//    List<char> opers = new List<char>();
//    List<double> numbers = new List<double>();

//    string[] parts = expression.Split(digitals, StringSplitOptions.RemoveEmptyEntries);
//    foreach (string part in parts)
//    {
//        if (part.Length > 0)
//        {
//            char op = part[0];
//            opers.Add(part[0]);
//            int index = expression.IndexOf(op);
//            Console.WriteLine($"Знак {part} имеет индекс {index}");
//        }
//    }

//    parts = expression.Split(operators, StringSplitOptions.RemoveEmptyEntries);
//    foreach (string part in parts)
//    {
//        if (int.TryParse(part, out int number))
//        {
//            numbers.Add(number);
//        }
//    }

//    if (opers.Count + 1 != numbers.Count)
//    {
//        Console.WriteLine("Некорректное выражение");
//        return;
//    }

//    List<int> uniquePriorities = new List<int>();
//    foreach (int priority in priorities)
//    {
//        if (!uniquePriorities.Contains(priority))
//        {
//            uniquePriorities.Add(priority);
//        }
//    }

//    foreach (int priority in uniquePriorities)
//    {
//        List<char> nowOpers = new List<char>();
//        for (int i = 0; i < priorities.Length; i++)
//        {
//            if (priorities[i] == priority)
//                nowOpers.Add(operators[i]);
//        }
//        for (int i = 0; i < opers.Count; i++)
//        {
//            if (operators.Contains(opers[i]))
//            {
//                numbers[i] = opers[i] switch
//                {
//                    '*' => numbers[i] * numbers[i + 1],
//                    '/' => numbers[i] / numbers[i + 1],
//                    '+' => numbers[i] + numbers[i + 1],
//                    '-' => numbers[i] - numbers[i + 1],
//                    _ => throw new NotSupportedException("Неподдерживаемый оператор")
//                };
//                numbers.RemoveAt(i + 1);
//                opers.RemoveAt(i);
//                i--;
//            }
//        }
//        Console.WriteLine($"Результат: {numbers[0]}");
//    }
//    //vyvod.Close();
//    //vvod1.Close();
//}
//catch (Exception ex)
//{
//    Console.WriteLine("ошибка");
//}

//Console.ReadKey();












using System;
using System.Collections.Generic;

Console.WriteLine("Введите математическое выражение: ");
string expression = Console.ReadLine();

try
{
    expression = expression.Replace(" ", "");
    char[] operators = "*/+-".ToCharArray();
    int[] priorities = new[] { 1, 1, 0, 0 };

    List<char> opers = new List<char>();
    List<int> numbers = new List<int>();

    for (int i = 0; i < expression.Length; i++)
    {
        char currentChar = expression[i];
        if (Array.Exists(operators, op => op == currentChar))
        {
            opers.Add(currentChar);
        }
        else if (char.IsDigit(currentChar))
        {
            int number = 0;
            while (i < expression.Length && char.IsDigit(expression[i]))
            {
                number = number * 10 + (expression[i] - '0');
                i++;
            }
            numbers.Add(number);
            i--; 
        }
    }

    if (opers.Count + 1 != numbers.Count)
    {
        Console.WriteLine("Некорректное выражение");
        return;
    }

    foreach (int p in new[] { 1, 0 }) 
    {
        for (int i = 0; i < opers.Count;)
        {
            char op = opers[i];
            int opIndex = Array.IndexOf(operators, op);
            if (opIndex >= 0 && priorities[opIndex] == p)
            {
                int left = numbers[i];
                int right = numbers[i + 1];
                int result = op switch
                {
                    '*' => left * right,
                    '/' => left / right,
                    '+' => left + right,
                    '-' => left - right,
                    _ => throw new NotSupportedException("Неподдерживаемый оператор")
                };

                numbers[i] = result;
                numbers.RemoveAt(i + 1);
                opers.RemoveAt(i);
            }
            else
            {
                i++;
            }
        }
    }

    Console.WriteLine($"Результат: {numbers[0]}");
}
catch (Exception ex)
{
    Console.WriteLine("Ошибка: " + ex.Message);
}













//using Microsoft.VisualBasic;
//using System;
//using static System.Net.Mime.MediaTypeNames;
////StreamWriter vvod = new StreamWriter("C:/Users/irisp/source/repos/StringsMathExpressions/StringsMathExpressions/vvod.txt");
//Console.WriteLine("Введите математическое выражение: ");
//string expression = Console.ReadLine();
////vvod.Close();
////StreamWriter vyvod = new StreamWriter("C:/Users/irisp/source/repos/StringsMathExpressions/StringsMathExpressions/vyvod.txt");
////StreamReader vvod1 = new StreamReader("C:/Users/irisp/source/repos/StringsMathExpressions/StringsMathExpressions/vvod1.txt");
//try
//{
//    expression = expression.Replace(" ", "");
//    string highPriority = "*/";
//    string lowPriority = "+-";
//    string operatorChars = "^*/+-";
//    List<int> operatorIndexes = new List<int>();
//    int index = 0;
//    foreach (char operators in expression)
//    {
//        if (operatorChars.Contains(operators))
//        {
//            operatorIndexes.Add(index);
//            Console.WriteLine($"Оператор {operators} в индексе {index}");
//        }
//        index++;
//    }






//    string[] razdel = expression.Split(" ");
//    int x = Convert.ToInt32(razdel[0]);
//    int y = Convert.ToInt32(razdel[2]);

//    string otvet = "Ответ: ";

//    switch (razdel[1])
//    {
//        case "+": Console.WriteLine(otvet + (x + y)); break;
//        case "-": Console.WriteLine(otvet + (x - y)); break;
//        case "*": Console.WriteLine(otvet + (x * y)); break;
//        case "/": Console.WriteLine(otvet + (x / y)); break;
//    }

//    //vyvod.Close();
//    //vvod1.Close();
//}
//catch (Exception ex)
//{
//    Console.WriteLine("ошибка");
//}

//Console.ReadKey();

////case "+": Console.WriteLine(otvet + (x + y)); vyvod.WriteLine(otvet + (x + y)); break;
////case "-": Console.WriteLine(otvet + (x - y)); vyvod.WriteLine(otvet + (x - y)); break;
////case "*": Console.WriteLine(otvet + (x * y)); vyvod.WriteLine(otvet + (x * y)); break;
////case "/": Console.WriteLine(otvet + (x / y)); vyvod.WriteLine(otvet + (x / y)); break;
