using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNROAD_EMPLOYEE_DETAILS
{
    class DataAccessImpl : DataAccess
    {

        SampleDataContext db = new SampleDataContext();

        public void add()
        {
            Console.WriteLine(" 1 --->> FOR PERMANENT EMPLOYEES ");
            Console.WriteLine(" 2 ---->> FOR TEMOPORARY EMPLOYEES ");

            int c =Convert.ToInt32( Console.ReadLine());

            if(c==1)
            {
                SeniorDeveloper sde = new SeniorDeveloper();
                sde.AnnualPay = 1000000;
                sde.Email = "kajcbgk@gmail.com";
              //  sde.EmployeeID = 1;
                sde.FirstName = " mary ";
                sde.LastName = " kom ";
               // sde.EmployeeType = "SeniorDeveloper";

                db.InnroadEmployees.InsertOnSubmit(sde);
                db.SubmitChanges();

                

            }
            else
            {

               Trainee sde = new Trainee();

                sde.HourlyPay = 100;
                sde.WeeklyPay = 7000;
                sde.Email = "kajcbgk@gmail.com";
              //  sde.EmployeeID = 1;
                sde.FirstName = " Temp ";
                sde.LastName = " Job ";
              //  sde.EmployeeType = "Trainee";

                db.InnroadEmployees.InsertOnSubmit(sde);
                db.SubmitChanges();


            }




        }

        public void view()
        {
            Console.WriteLine(" 1 --> TO VIEW ALL EMPLOYEES ");

            Console.WriteLine(" 2 --> TO VIEW ONLY SENOIR DEVELOPER ");

            Console.WriteLine(" 3 --> TO VIEW ONLY TRAINEE ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {

                case 1:
                   var x = db.InnroadEmployees.ToList();
                    foreach(var emp in x)
                    {
                        Console.WriteLine(emp.Email + " " + emp.EmployeeID +  " " +emp.EmployeeType +  " " + emp.FirstName +  " " + emp.LastName);
                    }

                    break;

                    case 2:
                    var y = db.InnroadEmployees.OfType<SeniorDeveloper>().ToList();
                    foreach (var emp in y)
                    {
                        Console.WriteLine(emp.Email + " " + emp.EmployeeID + " " + emp.EmployeeType + " " + emp.FirstName + " " + emp.LastName + " "+ emp.AnnualPay);
                    }
                    break;

                case 3:
                    var z = db.InnroadEmployees.OfType<Trainee>().ToList();
                    foreach (var emp in z)
                    {
                        Console.WriteLine(emp.Email + " " + emp.EmployeeID + " " + emp.EmployeeType + " " + emp.FirstName + " " + emp.LastName + " " + emp.WeeklyPay + " "+ emp.HourlyPay);
                    }

                    break;


            }



        }
    }
}
