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
        }
    }
}
