using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNROAD_EMPLOYEE_DETAILS
{
    class Program
    {
        static void Main(string[] args)
        {

            DataAccess data = new DataAccessImpl();

            while (1 == 1)
            {
                Console.WriteLine("1--> to add Employee data ");
                Console.WriteLine(" 2--> to view employee data ");

                int c = Convert.ToInt32(Console.ReadLine());

                if (c == 1)
                {
                    // Add Employee data 


                   

                    data.add();

                    Console.WriteLine(" done");

                }

                else
                {

                    // view employee data 


                    data.view();

                }


            }



        }
    }
}
