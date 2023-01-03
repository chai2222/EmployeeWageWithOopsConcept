

namespace EmployeeWageComputationProblem
{
    public class EmployeeAttendance
    {
        public void checkAttendance()
        {
            const int is_Full_Time = 1;
            const int is_Part_Time = 2;
            const int is_Wage_Per_Hour = 20;
            const int num_Of_Working_days = 20;
            const int max_Hours_In_Month = 100;

            int emp_Wage = 0;
            int emp_Hour = 0;
            int total_Emp_Wage = 0;
            int total_Emp_Hour = 0;
            int total_Working_Days = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            while (total_Emp_Hour <= max_Hours_In_Month && total_Working_Days < num_Of_Working_days) ;
            {
                total_Working_Days++;
                switch (empCheck)
                {
                    case is_Full_Time:
                        Console.WriteLine("Employee Is Absent");
                        break;
                }
            }
            total_Emp_Wage += emp_Wage;
            Console.WriteLine("Day# :" + total_Working_Days + "Emp Hours :" + emp_Hour);
        
        total_Emp_Wage = total_Emp_Hour* is_Wage_Per_Hour;
        Console.WriteLine("Total Employee Wage :" + total_Emp_Wage);

        }   
    }
}
