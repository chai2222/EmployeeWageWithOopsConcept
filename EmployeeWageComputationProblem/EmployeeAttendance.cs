

namespace EmployeeWageComputationProblem
{
    public class EmployeeAttendance
    {
        public void checkAttendance()
        {
            const int is_Full_Time = 1;
            const int is_Wage_Per_Hour = 20;

            const int is_Part_Time = 2;

            int emp_Wage = 0;
            int emp_Hour = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            switch (empCheck)
            {
                case is_Full_Time:
                    Console.WriteLine("Employee Is Present & Full Time");
                    emp_Hour = 8;
                    break;
                case is_Part_Time:
                    Console.WriteLine("Employee Is Part Time");
                    emp_Hour = 4;
                    break;
                case 0:
                    Console.WriteLine("Employee Is Absent");
                    break;
            }

            emp_Wage = emp_Hour * is_Wage_Per_Hour;
            Console.WriteLine("Employee Wage :" + emp_Wage);
        }
    }
}
