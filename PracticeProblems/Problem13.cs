class Problem13
{
    public static void Solve()
    {
        int employeeNo;
        string employeeName;
        float basicSalary;
        
        System.Console.WriteLine("enter employee number : ");
        employeeNo = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("enter employee name : ");
        employeeName = System.Console.ReadLine() ?? "";

        System.Console.WriteLine("enter employee basic salary : ");
        basicSalary = Convert.ToInt32(System.Console.ReadLine());

        float pf = 0.12f*basicSalary;
        float hra = 0.2f*basicSalary;
        float da = 0.15f*basicSalary;


        float grossSalary = pf+hra+da+basicSalary;

        float netSalary = grossSalary - pf;

        System.Console.WriteLine("Report card");
        System.Console.WriteLine($"employee number is {employeeNo}");
        System.Console.WriteLine($"employee name is {employeeName}");
        System.Console.WriteLine($"employee basic salary is {basicSalary}");
        System.Console.WriteLine($"employee gross salary is {grossSalary}");
        System.Console.WriteLine($"employee netsalary is {netSalary}");



    }
}