using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Profile_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1. Williams Robert  2. Steven john  3. Jennifer Garner");
            Console.Write("Select the student with assigned numbers: ");

            int Selectednumber = Convert.ToInt16(Console.ReadLine());


            if (Selectednumber == 1)
            {
                Console.WriteLine(" Age : 25");
                Console.WriteLine(" DOB : 06/25/1993");
                Console.WriteLine(" University : University of Okaland");
                Console.WriteLine(" Major : Software Engineer");
            }

            if (Selectednumber == 2)
            {
                Console.WriteLine(" Age : 22");
                Console.WriteLine(" DOB : 08/02/1995");
                Console.WriteLine(" University : NY university");
                Console.WriteLine(" Major : Civil Engineer");
            }

            if (Selectednumber == 3)
            {
                Console.WriteLine(" Age : 28");
                Console.WriteLine(" DOB : 01/15/1987");
                Console.WriteLine(" University : University of florida");
                Console.WriteLine(" Major : Mechanical Engineer");
            }

            Console.ReadKey();
        }
    }
    
}
