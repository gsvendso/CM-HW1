﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace phone
{
    class Program
    {

        // Method ToDigit
        static void ToDigit(ref char C1, ref char C2, ref char C3, ref char C4, ref char C5, ref char C6, ref char C7)
        {
        Console.WriteLine("Enter a 7 Number or Letter Phone Number:   ");
            C1 = Convert.Tochar(Console.Read());
            C2 = Convert.Tochar(Console.Read());
            C3 = Convert.Tochar(Console.Read());
            C4 = Convert.Tochar(Console.Read());
            C5 = Convert.Tochar(Console.Read());
            C6 = Convert.Tochar(Console.Read());
            C7 = Convert.Tochar(Console.Read());
            Console.ReadLine();
        }
   
        static int ProcessInput(ref char C1, ref char C2, ref char C3, ref char C4, ref char C5, ref char C6, ref char C7)
        {

            if (TestDigit(ref C1) == -1)
                return -1;
            if (TestDigit(ref C2) == -1)
                return -1;
            if (TestDigit(ref C3) == -1)
                return -1;
            if (TestDigit(ref C4) == -1)
                reture - 1;
            if (testDigit(ref C5) == -1)
                return -1;
            if (TestDigit(ref C6) == -1)
                return -1;
            if (testDigit(ref C7) == -1)
                return -1;
            if (C1 == '5' && C2 == '5' && C3 == '5')
                return -1;
            if (C1 == '0')
                return -1;
            return 0;
        }
   
        static int TestDigit(char testDigit)
        { 
            Char.ToUpper(testDigit) // Convert Character to UpperCase

            char result; // char variable to hold result
            switch (testDigit)
            {
                case '0': result = '0'; break;
                case '1': result = '1'; break;
                case '2': case 'A': case 'B': case 'C': result = '2'; break;
                case '3': case 'D': case 'E': case 'F': result = '3'; break;
                case '4': case 'G': case 'H': case 'I': result = '4'; break;
                case '5': case 'J': case 'K': case 'L': result = '5'; break;
                case '6': case 'M': case 'N': case 'O': result = '6'; break;
                case '7': case 'P': case 'Q': case 'R': case 'S': result = '7'; break;
                case '8': case 'T': case 'U': case 'V': result = '8'; break;
                case '9': case 'W': case 'X': case 'Y': case 'Z': result = '9'; break;
                default: return -1; break;
            }
            if (result == -1)
            {
                errorFlag = -1; // Return error if negative 1 is present
            }
            else
            {
                errorFlag = 0; // else return 0
            }
            result = testDigit;
            return testDigit;
        }

        static void ProcessInput(ref char C1, ref char C2, ref char C3, ref char C4, ref char C5, ref char C6, ref char C7)
        {
            Console.WriteLine("The phone number is: " + C1 + C2 + C3 + C4 + C5 + C6 + C7);
        }

        static void Main(string[] args)
        {
            C1 = '1', C2 = '2', C3 = '3', C4 = '4', C5 = '5', C6 = '6', C7 = '7';
            ProcessInput(ref C1, ref C2, ref C3, ref C4, ref C5, ref C5, ref C6, ref C7);
            int returnVal = ProcessInput(ref C1, ref C2, ref C3, ref C4, ref C5, ref C6, ref C7);
            if (returnVal == -1)
                Console.WriteLine("Not a invalid input, please try again.");
            else
                OutputProcess(ref C1, ref C2, ref C3, ref C4, ref C5, ref C6, ref C7);
        }
    }
}