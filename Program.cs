using System;

namespace lab_3
{
    class Program
    {
       static void Main(string[] args)
       {
            bool cont = true;

        do
        { 
            Console.WriteLine("enter an integer between 1 and 100");


            string output;

            output = Console.ReadLine();

            int result = Int32.Parse(output);

            if (result % 2 != 0)
            {


                Console.WriteLine("integer " + result + " is odd");
            }

            else if (result % 2 == 0 && result >= 2 && result <= 25)
            {

                Console.WriteLine("integer is even and less than 25");
            }

            else if (result % 2 == 0 && result >= 26 && result <= 60)
            {

                Console.WriteLine("Even");

            }

            else if (result % 2 == 0 && result > 60)
            {


                Console.WriteLine(result + " is even");

            }

            else if (result % 2 != 0 && result > 60)
            {

            Console.WriteLine(result + " is odd");

            }

            else

            {
                Console.WriteLine("-1");

            }

            Console.WriteLine("do you wish to continue y/n");
            string name;
            name = Console.ReadLine();
            name = name.ToLower();
            name = name.Trim();
            if (name == "y")
            {
                // Console.WriteLine("Hello,World");
                cont = true;
            }
            else
            {
                cont = false;
                Console.WriteLine("goodbye");

            }
        } while (cont == true);





       }
    }
}
