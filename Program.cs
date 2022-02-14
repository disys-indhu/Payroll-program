using System;
public class Employee
{
    int Employee_id;
    long Mobile_no;
    string Employee_name, Employee_address, Mail_id;
    public void EmployeeData()
    {
        Console.Write("Enter name of the employee:");
        Employee_name = Console.ReadLine();
        Console.Write("Enter employee id:");
        Employee_id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter address of the employee:");
        Employee_address = Console.ReadLine();
        Console.Write("Enter mail id:");
        Mail_id = Console.ReadLine();
        Console.Write("Enter mobile number:");
        Mobile_no = Convert.ToInt64(Console.ReadLine());
    }
    public void DisplayData()
    {
        Console.Write("Employee name:" + Employee_name);
        Console.Write("\n");
        Console.Write("Employee id:" + Employee_id);
        Console.Write("\n");
        Console.Write("Address:" + Employee_address);
        Console.Write("\n");
        Console.Write("Mail id:" + Mail_id);
        Console.Write("\n");
        Console.Write("Mobile Number:" + Mobile_no);
        Console.Write("\n");
    }
}
class Programmer : Employee
{
    double salary, bp, da, hra, pf, club, net, gross;
    public void ProgrammerPay()
    {
        Console.Write("Enter basic pay:");
        bp = Convert.ToInt32(Console.ReadLine());
    }
    public void CalculateProgrammer()
    {
        da = (0.97 * bp);
        hra = (0.10 * bp);
        pf = (0.12 * bp);
        club = (0.1 * bp);
        gross = (bp + da + hra);
        net = (gross - pf - club);
        Console.Write("-----PAY SLIP FOR PROGRAMMER-----\n");
        Console.Write("Basic pay: Rs." + bp);
        Console.Write("\n");
        Console.Write("DA: Rs." + da);
        Console.Write("\n");
        Console.Write("HRA: Rs." + hra);
        Console.Write("\n");
        Console.Write("PF: Rs." + pf);
        Console.Write("\n");
        Console.Write("CLUB: Rs." + club);
        Console.Write("\n");
        Console.Write("GROSS SALARY: Rs." + gross);
        Console.Write("\n");
        Console.Write("NET SALARY: Rs." + net);
        Console.Write("\n");
    }
}
class AssistantProfessor : Employee
{
    double salary, bp, da, hra, pf, club, net, gross;
    public void AssistantPay()
    {
        Console.Write("Enter basic pay:");
        bp = Convert.ToInt32(Console.ReadLine());
    }
    public void CalculateAssistant()
    {
        da = (0.97 * bp);
        hra = (0.10 * bp);
        pf = (0.12 * bp);
        club = (0.1 * bp);
        gross = (bp + da + hra);
        net = (gross - pf - club);
        Console.Write("-----PAY SLIP FOR ASSISTANT PROFESSOR-----\n");
        Console.Write("Basic pay: Rs." + bp);
        Console.Write("\n");
        Console.Write("DA: Rs." + da);
        Console.Write("\n");
        Console.Write("HRA: Rs." + hra);
        Console.Write("\n");
        Console.Write("PF: Rs." + pf);
        Console.Write("\n");
        Console.Write("CLUB: Rs." + club);
        Console.Write("\n");
        Console.Write("GROSS SALARY: Rs." + gross);
        Console.Write("\n");
        Console.Write("NET SALARY: Rs." + net);
        Console.Write("\n");
    }
}
class AssociateProfessor : Employee
{
    double salary, bp, da, hra, pf, club, net, gross;
    public void AssociatePay()
    {
        Console.Write("Enter basic pay:");
        bp = Convert.ToInt32(Console.ReadLine());
    }
    public void CalculateAssociate()
    {
        da = (0.97 * bp);
        hra = (0.10 * bp);
        pf = (0.12 * bp);
        club = (0.1 * bp);
        gross = (bp + da + hra);
        net = (gross - pf - club);
        Console.Write("-----PAY SLIP FOR ASSOCIATE PROFESSOR-----\n");
        Console.Write("Basic pay: Rs." + bp);
        Console.Write("\n");
        Console.Write("DA: Rs." + da);
        Console.Write("\n");
        Console.Write("HRA: Rs." + hra);
        Console.Write("\n");
        Console.Write("PF: Rs." + pf);
        Console.Write("\n");
        Console.Write("CLUB: Rs." + club);
        Console.Write("\n");
        Console.Write("GROSS SALARY: Rs." + gross);
        Console.Write("\n");
        Console.Write("NET SALARY: Rs." + net);
        Console.Write("\n");
    }
}
class Professor : Employee
{
    double salary, bp, da, hra, pf, club, net, gross;
    public void ProfessorPay()
    {
        Console.Write("Enter basic pay:");
        bp = Convert.ToInt32(Console.ReadLine());
    }
    public void CalculateProfessor()
    {
        da = (0.97 * bp);
        hra = (0.10 * bp);
        pf = (0.12 * bp);
        club = (0.1 * bp);
        gross = (bp + da + hra);
        net = (gross - pf - club);
        Console.Write("-----PAY SLIP FOR PROFESSOR-----\n");
        Console.Write("Basic pay: Rs." + bp);
        Console.Write("\n");
        Console.Write("DA: Rs." + da);
        Console.Write("\n");
        Console.Write("HRA: Rs." + hra);
        Console.Write("\n");
        Console.Write("PF: Rs." + pf);
        Console.Write("\n");
        Console.Write("CLUB: Rs." + club);
        Console.Write("\n");
        Console.Write("GROSS SALARY: Rs." + gross);
        Console.Write("\n");
        Console.Write("NET SALARY: Rs." + net);
        Console.Write("\n");
    }
}
class Salary
{
    public static void Main(string[] args)
    {
        int choice, count;
        do
        {
            Console.Write("PAYROLL\n");
            Console.Write("1.PROGRAMMER\n2.ASSISTANT PROFESSOR\n3.ASSOCIATE PROFESSOR\n4.PROFESSOR\n");
            {
                Console.Write("Enter your choice:");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Programmer prog = new Programmer();
                        prog.EmployeeData();
                        prog.ProgrammerPay();
                        prog.DisplayData();
                        prog.CalculateProgrammer();
                        break;
                    case 2:
                        AssistantProfessor asst = new AssistantProfessor();
                        asst.EmployeeData();
                        asst.AssistantPay();
                        asst.DisplayData();
                        asst.CalculateAssistant();
                        break;
                    case 3:
                        AssociateProfessor asso = new AssociateProfessor();
                        asso.EmployeeData();
                        asso.AssociatePay();
                        asso.DisplayData();
                        asso.CalculateAssociate();
                        break;
                    case 4:

                        Professor prof = new Professor();
                        prof.EmployeeData();
                        prof.ProfessorPay();
                        prof.DisplayData();
                        prof.CalculateProfessor();
                        break;
                }
            }
            Console.WriteLine("Enter 0 to quit and 1 to continue:");
            count = int.Parse(Console.ReadLine());
        } while (count == 1);
    }

}
