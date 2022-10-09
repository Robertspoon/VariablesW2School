using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesW2School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Robert "; //string
            string lastName = "Atkinson"; //string
            string fullName = name + lastName; //string
            long Value = 15000000000L; //Integer (Whole number)
            double Decimal = 19.99D; //Floating Point number (Decimal number)
            char letter = 'R'; // Character
            bool myBool = false; //Boolean
            int x, y, z; //string
            x = y = z = 67;
            float f1 = 35e3F;
            double d1 = 12E4D;
            bool iGetBitches = false;
            bool amIMentallyIll = true;
            char myGrade = 'F';
            double myDouble = 9.78D;
            bool myBool2 = false;
            int myInt = (int) myDouble;
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Full name: " + fullName);
            Console.WriteLine("Value: " + Value);
            Console.WriteLine("Decimal: " + Decimal);
            Console.WriteLine("Letter: " + letter);
            Console.WriteLine("Bool: " + myBool);
            Console.WriteLine("67 * 3 = " + (x + y + z));
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            Console.WriteLine("I get bitches: " + iGetBitches);
            Console.WriteLine("I am mentally ill: " + amIMentallyIll);
            Console.WriteLine("What are my grades? : " + myGrade);
            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);
            Console.WriteLine();

            //castings
            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool2));
            Console.WriteLine(Convert.ToBoolean(myInt));
            

            

            Console.ReadKey(true);
        }
    }
}
