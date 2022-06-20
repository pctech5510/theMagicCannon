// See https://aka.ms/new-console-template for more information

//Write a program that will loop through values between 1 and 100 and display what kind of blast the crew should expect.
//(The % may be of use)

//Change the color of the output based on the type of blast. ( Red for fire, yellow for electric, and blue for electric and fire
/*Every third crank FIRE (Red)
 * Every fifth crank ELECTRIC (Yellow)
 * When FIRE and ELECTRIC are COMBINE (Blue)
 * Example output
 * 1: normal
 * 2: normal
 * 3: fire
 * 4: normal
 * 5: electric
 * 6: fire
 * 7: normal
 */

Console.WriteLine("The Magic Cannon\n");

for (int i = 1; i <= 100; i++)

    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{i}:Big Boom!");
    }
    else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}:Fire");
    }
    else if (i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{i}:Electric!!");
    }

    else
        Console.WriteLine($"{i}:Normal");