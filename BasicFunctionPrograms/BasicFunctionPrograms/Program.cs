// See https://aka.ms/new-console-template for more information
Console.WriteLine("1. Flip Coin\n2. Leap Year");
int choice = Convert.ToInt32(Console.ReadLine());
switch ( choice )
{
    case 1:
        BasicFunctionPrograms.FlipCoinPercentage output = new BasicFunctionPrograms.FlipCoinPercentage();
        output.FlipCoin();
        break;
    case 2:
        BasicFunctionPrograms.LeapYear year = new BasicFunctionPrograms.LeapYear();
        year.LeapYearProg();
        break;
    default: Console.WriteLine("Invalid Input");
        break;
}
