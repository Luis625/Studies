/* Here are listed some useful information about conditional statements and repetition loops. */
using System;

namespace SketchyWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 3, 4, 15, 25, 30, 40 };

            foreach (int number in arrayOfNumbers) Console.WriteLine($"This number is {number}");
        }

    }
}

/* if-else and switch statements are implemented almost in the same in C# and other C languages such as C and C++. */

/* A good guideline that make you less susceptible to mistakes is to not use curly braces in conditional statements and repetition loops
 only when the statement is written in the same line as the if/else/for... statement. */

/* In C#, switch statements do not allow fall-through functionality unless you use empty cases to make values with the same behavior:
 case 1:
 case 2:
 case 3:
    Console.WriteLine("It works!");
    break;
 default: [...]

 * In switch statements, the order of the cases doesn't matter. You can even put the default first.
 * With C# 7, when using pattern matching, the order of the cases becomes important.
 * Another thing different from another C languages is that in C#, you can use strings as the value being tested*/

/* C# brings a new repetition loop called foreach. It basically runs through a collection os objects:
 * foreach (int number in arrayOfNumbers) Console.WriteLine($"This number is {number}"); 
 * Just remember, you can't change the value of the item in the collection in a foreach loop. */

/* The book also covers goto statements, but they don't worth it. Remember, you can do everything without it. They only bring problems.*/

/* The real useful Jump Statements covered in the book are: 
 * break -> exits from the innermost repetition loop and the switch statement.
 * continue -> works like break, but instead of exiting from the repetition loops, it just end the current interation of the loop.
 * return -> exits from a method of a class, returning the value explicited. Must return a value of the same type as the method. */
