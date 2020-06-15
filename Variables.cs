/* Here, comments about variable, notations and useful tips are mentioned.*/

using System;

namespace SketchyWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Aragorn.";
            int idade = 0b101010101010;
            Console.WriteLine("My name is {str1}");
            Console.WriteLine($"My name is {str1}");
            Console.WriteLine($"I have {idade} years old");

        }

    }
}

/* Value types are stored in an area known as the stack. -> int for example.*/
/* Reference types are stored in an area known as the managed heap. -> Vector for example*/

/* All integer-type can be assigned values in decimal, hex, or binary notation.
 * Binary notation -> 0b
 * Hexa notation   -> 0x
 * You can use underscores that has no funcionality, but makes easier the reading. -> long l1 = 0x123_4567_89ab_cdef;
 */

/* You can also specify a type for a value:
 * 0.83471F -> float.
 * U -> Unsigned int.
 * L -> Long
 * UL -> Unsigned Long
 * M -> Decimal (money) (See next item)
 * 0x -> Hexadecimal number
 * 0b -> Binary number
 * When you don't specify the rational number, it assumes that is a double*/

/* Good thing to know! There is another type for rational numbers: Decimal
 * It's not a primitive type, so affecs your performance, but the advantage is a higher-precision floating-point number.
 * To specify the type Decimal to a value, you can also use this: 4.192848M */

/* C# diferenciates single from double quotes. So "A" is a string with one character and 'A' is a char type. */

/* There is a type called object. It's a more primitive type, or a root type, from wich all other types that are
intrinsec or user-defined are hierarchy derived. */ 

/* The string type is allocatedon on the heap, not on the stack. That said, if you use:
str1 = str2 and you make modifications to str2, you will also making modifications to str1. 
 * String are imutable. Making changes to str1 or str2 creates another string.
 * Therefor you can't change a string, but you can reasign the reference to a new object.*/

/* The character '\' is used to scape sequences. To use backlashes, you need to double type it.
 * Fortunately, if you're going to use repeatedly, you can just put @ before the string -> @"C:\ProCSharp\First.cs"
 * When you put @ before, your line breaks are also considered in the output.
 * When you put $ before, you allow string interpolation. If you have s1 = "Hello."; for example:
 $"s1 is {s1}" -> s1 is Hello. Also works with other types of variables instead of only strings.
 */

