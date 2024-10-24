using static System.Net.Mime.MediaTypeNames;
try
{
    StreamWriter vvod = new StreamWriter("C:/Users/irisp/source/repos/StringsMathExpressions/StringsMathExpressions/vvod.txt");
    Console.WriteLine("Введите простое математическое выражение");
    string expression = Console.ReadLine();
    vvod.Close();
    StreamWriter vyvod = new StreamWriter("C:/Users/irisp/source/repos/StringsMathExpressions/StringsMathExpressions/vyvod.txt");
    StreamReader vvod1 = new StreamReader("C:/Users/irisp/source/repos/StringsMathExpressions/StringsMathExpressions/vvod1.txt");

    string[] razdel = expression.Split(" ");
    int x = Convert.ToInt32(razdel[0]);
    int y = Convert.ToInt32(razdel[2]);

    string otvet = "Ответ: ";

    switch (razdel[1])
    {
        case "+": Console.WriteLine(otvet + (x + y)); vyvod.WriteLine(otvet + (x + y)); break;
        case "-": Console.WriteLine(otvet + (x - y)); vyvod.WriteLine(otvet + (x - y)); break;
        case "*": Console.WriteLine(otvet + (x * y)); vyvod.WriteLine(otvet + (x * y)); break;
        case "/": Console.WriteLine(otvet + (x / y)); vyvod.WriteLine(otvet + (x / y)); break;
    }
    vyvod.Close();
    vvod1.Close();
} catch (Exception ex) 
{
    Console.WriteLine("ошибка");
}