using Microsoft.VisualBasic;
using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
//StreamWriter vvod = new StreamWriter("C:/Users/irisp/source/repos/StringsMathExpressions/StringsMathExpressions/vvod.txt");
Console.WriteLine("Введите математическое выражение: ");
string expression = Console.ReadLine();
//vvod.Close();
//StreamWriter vyvod = new StreamWriter("C:/Users/irisp/source/repos/StringsMathExpressions/StringsMathExpressions/vyvod.txt");
//StreamReader vvod1 = new StreamReader("C:/Users/irisp/source/repos/StringsMathExpressions/StringsMathExpressions/vvod1.txt");
try
{
    expression = expression.Replace(" ", "");
    char[] operators = "*/+-".ToCharArray();
    char[] digitals = "0123456789".ToCharArray();
    int[] priorities = new[] { 0, 0, 1, 1 };

    List<char> opers = expression.Split(digitals, StringSplitOptions.RemoveEmptyEntries).Select(s => s[0]).ToList();
    List<int> numbers = expression.Split(operators, StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToInt32(s)).ToList();

    if (opers.Count + 1 != numbers.Count)
    {
        Console.WriteLine("Некорректное выражение");
        return;
    }

    foreach (int priority in priorities.Distinct())
    {
        List<char> nowOpers = new List<char>();
        for (int i = 0; i < priorities.Length; i++)
        {
            if (priorities[i] == priority)
                nowOpers.Add(operators[i]);
        }

    }





    //vyvod.Close();
    //vvod1.Close();
}
catch (Exception ex)
{
    Console.WriteLine("ошибка");
}

Console.ReadKey();

//case "+": Console.WriteLine(otvet + (x + y)); vyvod.WriteLine(otvet + (x + y)); break;
//case "-": Console.WriteLine(otvet + (x - y)); vyvod.WriteLine(otvet + (x - y)); break;
//case "*": Console.WriteLine(otvet + (x * y)); vyvod.WriteLine(otvet + (x * y)); break;
//case "/": Console.WriteLine(otvet + (x / y)); vyvod.WriteLine(otvet + (x / y)); break;











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
