using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Reflection;

namespace Assignment
{

    internal class Program

    {
        static void PassingByValue(int x) { x += 10; }
        static void PassingByReference(ref int x) { x += 10; }
        //Q3
        public static void SumSub(int x, int y, out int sum, out int sub)
        {
            sum = x + y;
            sub = x - y;


        }
        //Q4
        public static int SumDigit(int[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];

            }
            return sum;
        }
        public static int[] convertToArryInt(char[] z)
        { int x = z.Length;
            int[] intarray = new int[x];

            for (int i = 0; i < x; i++)

            {
                intarray[i] = z[i] - '0';

            }

            return intarray; }
        public static void MMinmaxArray(int[] x, ref int max, ref int mini)
        {
            max = x.Max();
            mini = x.Min();
        }
        public static int CalculateFactorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;

            }



            return result;

        }
        public static string ChangeChar(string str, int position, char newChar)
        {
            if (position < 0 || position >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range.");
            }
            char[] charArray = str.ToCharArray();
            charArray[position] = newChar;
            return new string(charArray); }


        //Q5
        public static bool isprime(int num)
        { if (num < 1)
            { return false; }
            for (int i = 2; i < num; i++)
            { if (num % i == 0)

                    return false;
            }
            return true;
        }
        //Q2
        public static int PassingReference(ref int x)
        {
            x = x + 5;
            return x; }
        public static int PassingValue(int x)
        { return x + 5; }

        static void Main(string[] args)
        {
            //#region Q1 
            ////1- Write a program that allows the user to insert an integer then print all numbers between 1 to
            ////that number.
            //Console.WriteLine("enter number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(i);


            //}
            //#endregion
            //#region Q2
            ////Write a program that allows the user to insert an integer then 
            ////print a multiplication table up to 12
            //Console.WriteLine("Q2: enter number");
            //int nu = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(i * nu);
            //    Console.Write(" ");
            //}
            //Console.WriteLine("  ");

            //#endregion
            //#region Q3
            ////Write a program that allows to user to insert number then print all even numbers between 1
            ////to this number
            //Console.WriteLine(" Q3: enter integer  number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i);
            //        Console.Write(" ");
            //    }
            //}
            //#endregion
            //Console.WriteLine("  ");

            //#region Q4
            ////Write a program that takes two integers then prints the power.
            //Console.WriteLine("Q4: enter integer  number");
            //int numb = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" enter integer  power for this number");
            //int power = Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //for (int i = 1; i <= power; i++)
            //{

            //    result = numb * result;

            //}
            //Console.WriteLine(result);

            //#endregion
            //#region Q5
            //// Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.WriteLine(" Q5: Enter string to reverse it");
            //string? name = Console.ReadLine();
            //Char[] chars = name.ToArray();
            //int index = chars.Length;

            //for (int i = 1; i < index; i++)
            //{
            //    Console.Write(chars[index - i]);
            //}

            //#endregion
            //#region Q6
            ////6- Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.WriteLine(" Q6: Enter int to reverse it");
            //string? inbut = Console.ReadLine();
            //char[] ints = inbut.ToArray();

            //int ind = ints.Length;

            //for (int i = 1; i <= ind; i++)
            //{
            //    Console.Write(ints[ind - i]);
            //}



            //#endregion
            //#region Q7
            ////Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.WriteLine("Enter the start of the range to find prime numbers:");
            //int start = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the end of the range:");
            //int end = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Prime numbers between {start} and {end} are:");
            //for (int i = start; i <= end; i++)
            //{
            //    if (isprime(i))
            //    {
            //        Console.Write(i);
            //        Console.Write(" ");
            //    }
            //}
            //Console.WriteLine();
            //#endregion
            #region Q18
            //- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array.
            //Now copy all the elements of first array on second array and print second array.
            int[,] num01= new int[5];
            int[,] num02= new int[5];
            for (int i = 0; i < num01.GetLength(0); i++)
            {
                Console.WriteLine($"Enter Element of Row : {i+1}");
                for(int j = 0;  j < num01.GetLength(1); ) 
                {
                    Console.WriteLine($"Enter Element of column :{i + 1}");
                    bool isparsed = int.TryParse(Console.ReadLine(), out num01[i, j]);
                        if (isparsed)
                        j++;


                }
            }
            #endregion
        //    #region Q19
        //    // Write a Program to Print One Dimensional Array in Reverse Order
        //    int[] oneD = { 50, 30, 28, 90 };
        //    Console.WriteLine("Original array:");
        //        for (int i = 0; i < oneD.Length; i++) 
        //        {Console.Write(oneD[i] );
        //        Console.Write(" ");
        //        }
        //        Console.WriteLine();
        //    Array.Sort(oneD);
        //    Array.Reverse(oneD);
        //    Console.WriteLine("Array in reverse order:");
        //    for (int i = 0; i < oneD.Length; i++)
        //    {
        //        Console.Write(oneD[i] );
        //        Console.Write(" ");
        //    }
        //    Console.WriteLine();

        //    #endregion
        //    #region function
        //    #region Q1
        //    /*Passing by Value
        //        When you pass a value type parameter by value, you pass a copy of the data 
        //    to the method.Any changes made to the parameter inside the method do not affect the original data.

        //   Passing by Reference
        //        When you pass a value type parameter by reference, you pass the memory address of the data to the 
        //    method. This means any changes made to the parameter inside the method directly affect the original data.*/


        //    int a = 5; int b = 5;
        //    Console.WriteLine("Value of a (by value): " + a);
        //    Console.WriteLine("Value of b (by reference): " + b);

        //    PassingByValue(a);
        //    PassingByReference(ref b);

        //    Console.WriteLine("Value of a (by value): " + a);

        //    Console.WriteLine("Value of b (by reference): " + b);

        //    #endregion
        //    #region Q2
        //    /*Passing Reference Type Parameters by Value
        //        When you pass a reference type parameter by value, you pass a copy of the reference to the object.
        //    While you can modify the object's properties or fields through this reference, you cannot change 
        //    the original reference to point to a new object outside the method.

        //Passing Reference Type Parameters by Reference
        //     When you pass a reference type parameter by reference, you pass the actual reference itself.
        //    This allows the method to change which object the reference points to, and any changes to the object's
        //    properties or fields will also reflect outside the method.
        //     */
        //    int x = 10;
        //    Console.WriteLine($"value of x before any action is : {x}");
        //    int v = PassingValue(x);
        //    Console.WriteLine($"value of x inside passing bu value is : {v}");
        //    Console.WriteLine($"value of x after passing by value : {x}");

        //    int m = PassingReference(ref x);
        //    Console.WriteLine($"value of x during  passing by ref is : {m}");
        //    Console.WriteLine($"value of x after  passing by ref is : {x}");




        //    #endregion
        //    #region Q3
        //    //Write a c# Function that accept 4 parameters from user and return result of
        //    //summation and subtracting of two numbers
        //    Console.WriteLine("enter integer number 1");
        //    Console.Write("number 1 : ");
        //    int A = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("enter integer number 2");
        //    Console.Write("number 2 : ");
        //    int B = Convert.ToInt32(Console.ReadLine());
        //    int resultsum;
        //    int resultsub;

        //    SumSub(A, B, out resultsum, out resultsub);
        //    Console.WriteLine($"result sum = {resultsum}");
        //    Console.WriteLine($"result sub = {resultsub}");
        //    #endregion
        //    Console.WriteLine(" ");
        //    #region Q4
        //    //Write a program in C# Sharp to create a function to calculate the
        //    //sum of the individual digits of a given number.
        //    Console.WriteLine("enter integer numberto calculate the sum of the individual digits ");
        //    Console.Write("number  : ");
        //    string numdigit = Console.ReadLine();
        //    char[] chararray = numdigit.ToArray();
        //    int[] number = convertToArryInt(chararray);

        //    int print = SumDigit(number);
        //    Console.WriteLine($"{print}");


        // #endregion
        //    #region Q5
        //    //Create a function named "Is Prime", which receives an integer number and
        //    //returns true if it is prime, or false if it is not:
        //    Console.WriteLine("enter number to chek is prime or not ");
        //    Console.Write("number : ");
        //    int iprime = Convert.ToInt32(Console.ReadLine());
        //    bool cheker = isprime(iprime);
        //    Console.WriteLine($"{cheker}");


        //    #endregion
        //    #region Q6
        //    //Create a function named Minmax Array, to return the minimum and
        //    //maximum values stored in an array, using reference parameters
        //    Console.WriteLine("enter integer number of array ");
        //    Console.Write("Array  : ");
        //    string nummaxmin = Console.ReadLine();
        //    char[] chararray2 = nummaxmin.ToArray();
        //    int[] number2 = convertToArryInt(chararray2);
        //    int max = 0;
        //    int mini = 0;
        //    MMinmaxArray(number2, ref max, ref mini);
        //    Console.WriteLine($"max= {max}");
        //    Console.WriteLine($"mini= {mini}");
        //    #endregion
        //    #region Q7
        //    Console.WriteLine("Enter a number to calculate its factorial:");
        //    int number4 = Convert.ToInt32(Console.ReadLine());
        //    int factorial = CalculateFactorial(number4);
        //    Console.WriteLine($"The factorial of {number4} is: {factorial}");
        //    #endregion
        //    #region Q8
        //    //8-Create a function named "Change Char" to modify a letter in a certain position
        //    //(0 based) of a string, replacing it with a different letter
        //    Console.WriteLine("Enter a string:");
        //    string originalString = Console.ReadLine();
        //    Console.WriteLine("Enter the position (0-based) of the character to change:");
        //    int position = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter the new character:");
        //    char newChar = Console.ReadKey().KeyChar;
        //    Console.WriteLine();
        //    string modifiedString = ChangeChar(originalString, position, newChar);
        //    Console.WriteLine("Modified string: " + modifiedString);

        //    #endregion


        //    #endregion





        }
    }
}