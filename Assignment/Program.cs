namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            //1- Write a program that allows the user to insert an integer then print all numbers between 1 to
            //that number.
            Console.WriteLine("enter number");
           int n=Convert.ToInt32(Console.ReadLine());   
           for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);


            }
            #endregion
            #region Q2
            //Write a program that allows the user to insert an integer then 
            //print a multiplication table up to 12
            Console.WriteLine("enter number");
            int nu = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.Write(i* nu);
                Console.Write(" ");
            }
            Console.WriteLine("  ");
            #region Q3
            //Write a program that allows to user to insert number then print all even numbers between 1
            //to this number
            Console.WriteLine("enter integer  number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i%2==0)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
            #endregion

            #endregion
        }
    }
}
