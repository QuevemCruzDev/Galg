public class Program
{
    public Program()
    {

    }
    public static async Task Main(string[] args)
    {
        if (args.Count() <= 0)
        {
            Console.WriteLine("Por favor use algum paramentro: \nsum -Adição , \nsub-> Subtração, \nmul->multiplicação ou \ndiv -> Divisão");
        }
        else
        {


            string comand = args[0];
            string[] comandLine = args.Where((value, index) => index != 0).ToArray();

            List<double> Numbers = [];

            for (int i = 0; i < comandLine.Count(); i++)
            {
                if (!double.TryParse(comandLine[i], out double number))
                {
                    Console.WriteLine($"{comandLine[i]} não é um numero valido");
                }
                else
                {
                    Numbers.Add(number);
                    Console.WriteLine($"{comand.ToUpper()}: {comandLine[i]}");
                }
            }
            switch (comand.ToLower())
            {
                case "sum":
                    Console.WriteLine($"Resultado: {Sum(Numbers)}");
                    break;
                case "sub":
                    Console.WriteLine($"Resultado: {Sub(Numbers)}");
                    break;
                case "mult":

                    Console.WriteLine($"Resultado: {Mult(Numbers)}");
                    break;
                case "div":
                    if (Numbers.Count() > 2)
                        Console.WriteLine("Esta operação aceita apenas 2 numero como parametro");
                    else
                        Console.WriteLine($"Resultado: {Div(Numbers)}");
                    break;
                default:
                    Console.WriteLine("Comando Invalido");
                    break;
            }
        }

    }
    public static double Sum(List<double> numbers)
    {
        double result = numbers[0];
        for (int i = 1; i < numbers.Count(); i++)
        {
            result = result + numbers[i];
        }
        return result;
    }

    public static double Sub(List<double> numbers)
    {
        double result = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
        {

            result = result - numbers[i];

        }
        return result;
    }
    public static double Mult(List<double> numbers)
    {
        double result = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
        {

            result = result * numbers[i];

        }
        return result;
    }
    public static double Div(List<double> numbers)
    {

        if (numbers.Count < 2 || numbers[1] == 0)
        {
            Console.WriteLine("Erro em divisão por 0");
            return 0;
        }
        return numbers[0] / numbers[1];
    }
}