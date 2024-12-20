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
        static void Main(string[] args)
        {
            //    #region Q1 
            //    //1- Write a program that allows the user to insert an integer then print all numbers between 1 to
            //    //that number.
            //    Console.WriteLine("enter number");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    for (int i = 1; i <= n; i++)
            //    {
            //        Console.WriteLine(i);


            //    }
            //    #endregion
            //    #region Q2
            //    //Write a program that allows the user to insert an integer then 
            //    //print a multiplication table up to 12
            //    Console.WriteLine("Q2: enter number");
            //    int nu = Convert.ToInt32(Console.ReadLine());
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.Write(i * nu);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("  ");

            //    #endregion
            //    #region Q3
            //    //Write a program that allows to user to insert number then print all even numbers between 1
            //    //to this number
            //    Console.WriteLine(" Q3: enter integer  number");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    for (int i = 1; i <= num; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.Write(i);
            //            Console.Write(" ");
            //        }
            //    }
            //    #endregion
            //    Console.WriteLine("  ");

            //    #region Q4
            //    //Write a program that takes two integers then prints the power.
            //    Console.WriteLine("Q4: enter integer  number");
            //    int numb = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(" enter integer  power for this number");
            //    int power = Convert.ToInt32(Console.ReadLine());
            //    int result = 1;
            //    for (int i = 1; i <= power; i++)
            //    {

            //        result = numb * result;

            //    }
            //    Console.WriteLine(result);

            //    #endregion
            //    #region Q5
            //    // Write a program to allow the user to enter a string and print the REVERSE of it.

            //    Console.WriteLine(" Q5: Enter string to reverse it");
            //    string? name = Console.ReadLine();
            //    Char[] chars = name.ToArray();
            //    int index = chars.Length;

            //    for (int i = 1; i < index; i++)
            //    {
            //        Console.Write(chars[index - i]);
            //    }

            //    #endregion
            //    #region Q6
            //    //6- Write a program to allow the user to enter int and print the REVERSED of it.
            //    Console.WriteLine(" Q6: Enter int to reverse it");
            //    string? inbut =  Console.ReadLine();
            //    char[] ints = inbut.ToArray();

            //    int ind = ints.Length;

            //    for (int i = 1; i <= ind; i++)
            //    {
            //        Console.Write(ints[ind - i]);
            //    }


            //    #endregion

            #region function
            #region Q1
            /*Passing by Value
                When you pass a value type parameter by value, you pass a copy of the data 
            to the method.Any changes made to the parameter inside the method do not affect the original data.

           Passing by Reference
                When you pass a value type parameter by reference, you pass the memory address of the data to the 
            method. This means any changes made to the parameter inside the method directly affect the original data.*/


            int a = 5; int b = 5;
            Console.WriteLine("Value of a (by value): " + a); 
            Console.WriteLine("Value of b (by reference): " + b);

            PassingByValue(a);
            PassingByReference(ref b);

            Console.WriteLine("Value of a (by value): " + a);

            Console.WriteLine("Value of b (by reference): " + b);

            #endregion
            #endregion





        }
    }
}
