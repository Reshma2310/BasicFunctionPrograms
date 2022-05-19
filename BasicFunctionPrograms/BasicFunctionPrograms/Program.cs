// See https://aka.ms/new-console-template for more information
Console.WriteLine("1. Flip Coin\n2. Leap Year\n3. Power of 2");
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
    case 3:
        BasicFunctionPrograms.PowerOfTwo power = new BasicFunctionPrograms.PowerOfTwo();
        power.Power();
        break;
    default: Console.WriteLine("Invalid Input");
        break;
}
