Console.WriteLine("Basic arithmetics menu:");
Console.Write("1. Addition:[ + ]\t");
Console.Write("2. Subtraction:[ - ]\t");
Console.Write("3. Multiplication:[ * ]\t");
Console.Write("4. Division:[ / ]\t");


Console.Write("Pick one option: ");
string arithmeticOption = Console.ReadLine();


Console.WriteLine("Enter the first number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Enter the second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

switch (arithmeticOption)
{
    case "1":

        Console.WriteLine($"{firstNumber + secondNumber}");
        break;

    case "2":

        Console.WriteLine($"{firstNumber - secondNumber}");
        break;

    case "3":

        Console.WriteLine($"{firstNumber * secondNumber}");
        break;

    case "4":

        if(secondNumber == 0) {
            Console.WriteLine("It's not possible to divide 0");
        } else {
            Console.WriteLine($"{firstNumber / secondNumber}");
        }
        break;
    default:
    Console.WriteLine("Something went wrong. Please try again.");
    break;
}