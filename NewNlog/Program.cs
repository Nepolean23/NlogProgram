using System;


namespace NewNlog
{
    public class Program
    {
        static void Main(string[] args) 
        {
            AddNumber addnumber = new AddNumber();
            int result = addnumber.Sum(12, 13);
            Console.WriteLine(result);

        }
    }
}

