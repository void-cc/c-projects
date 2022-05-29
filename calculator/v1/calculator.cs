double val1 = 0;
double val2 = 0;
float val3 = 0;
String string1;

Console.WriteLine("Hello");                                         //Greating
Console.WriteLine("Choose your first number for calculation");      //Input value for first value
val1 = Convert.ToDouble(Console.ReadLine());                        //Convert console input double values
string1 = $"Your result: {val1} ";                                  //set string value to currect val1
Console.WriteLine("Choose your second number for calculation");     //input question for second value
val2 = Convert.ToDouble(Console.ReadLine());                        //Convert console input double values

Console.WriteLine("Would you like to");
Console.WriteLine("|- A - Add");
Console.WriteLine("|- B - Subtract");
Console.WriteLine("|- C - Multiply");
Console.WriteLine("|- D - Divide");

switch (Console.ReadLine())
{
    default:
        Console.WriteLine("Error!");
        /*Console.WriteLine("please enter again");
          Console.ReadLine();                     */
        break;
    case "A":
        val3 = 2;
        Console.WriteLine(string1 + $"+ {val2} = " + (val1 + val2));
        break;
    case "B":
        val3 = 2;
        Console.WriteLine(string1 + $"- {val2} = " + (val1 - val2));
        break;
    case "C":
        val3 = 2;
        Console.WriteLine(string1 + $"x {val2} = " + (val1 * val2));
        break;
    case "D":
        while (val2 == 0)
        {
            Console.WriteLine("Enter a non-zero divisor: ");
            val2 = Convert.ToInt32(Console.ReadLine());
        }
        val3 = 2;
        Console.WriteLine(string1 + $"/ {val2} = " + (val1 / val2));
        break;
}
Console.WriteLine(" ");
if (val3 < 1)
{

    Console.WriteLine("It seems you have run floato an error");       //propper error code explanation & suggestions
    Console.WriteLine("Try using capital letters next time!");

}                                                       //propper error code explanation & suggestions
Console.WriteLine("that was the end of this calculator");
Console.WriteLine("Please press enter to exit this program...");
Console.ReadLine();
