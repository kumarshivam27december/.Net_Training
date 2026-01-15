using System.Data;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {

        //-------------------------------------------------------//
        /*
        //data sources
        string[] names = { "Bill", "steve", "james", "mohan" };
        //write the query (using query syntax)
        // IEnumerable<string> name =   //alternative of var name =
        var name = from s in names
                   where s.Contains('a')
                   select s;
        //execute the query
        foreach (string s in name)
        {
            Console.WriteLine(s);
        }
        */



        //----------------------------------------------//




        /*
        string[] names = { "Bill", "steve", "james", "mohan" };
        //Method Syntax
        var name = names.Where(s=>s.Contains('a'));
        foreach (string s in name)
        {
            Console.WriteLine(s);
        }


        */

        //----------------------------------------------//

        /*
        //string collection datasource
        IList<string> stringList = new List<string>()
        {
            "C# tutorial",
            "VB.net tutorial",
            "Learn c++",
            "Mvc tutorial",
            "java"
        };
        //write query
        //link query syntax

        var result = from s in stringList
                        where s.Contains("tutorial")
                        select s;

        //execute the query

        foreach (var str in result)
        {
            Console.WriteLine(str);
        }


        */

        //----------------------------------------------------------------//
        /*

        //query syntax
        IList<Student> studentList = new List<Student>()
        {
            new Student() {StudentId=1,StudentName="name1",StudentAge = 13},
            new Student() {StudentId=2,StudentName="name2",StudentAge = 14},
            new Student() {StudentId=3,StudentName="name3",StudentAge = 15},
            new Student() {StudentId=4,StudentName="name4",StudentAge = 16},
            new Student() {StudentId=5,StudentName="name5",StudentAge = 17},
        };
        var students = from s in studentList 
                        where s.StudentAge>12 && s.StudentAge<20
                        select s;

        foreach (Student stu in students)
        {
            Console.WriteLine($"Id {stu.StudentId} Name {stu.StudentName} age {stu.StudentAge}");
        }

        */


        /*

        //method syntax
        IList<Student> studentList = new List<Student>()
        {
            new Student() {StudentId=1,StudentName="name1",StudentAge = 13},
            new Student() {StudentId=2,StudentName="name2",StudentAge = 14},
            new Student() {StudentId=3,StudentName="name3",StudentAge = 15},
            new Student() {StudentId=4,StudentName="name4",StudentAge = 16},
            new Student() {StudentId=5,StudentName="name5",StudentAge = 17},
        };

        var students = studentList.Where(s=>s.StudentAge>12 && s.StudentAge<20);
        foreach (Student stu in students)
        {
            Console.WriteLine($"Id {stu.StudentId} Name {stu.StudentName} age {stu.StudentAge}");
        }

        */


        //data source
        //create an instance of employee datatable
        var employees = new Employee();
        // Add rows to the data table

        employees.Rows.Add(1,"john smith",30,"IT",5000);
        employees.Rows.Add(2,"jane doe",25,"HR",4000);
        employees.Rows.Add(3,"bob johnson",35,"IT",6000);
        employees.Rows.Add(4,"samantha williams",28,"Marketing",4500);


        //write linq query
        //use linq to query the data table

        var query = from employee in employees.AsEnumerable()
                    where employee.Field<string>("department") =="IT"
                    orderby employee.Field<int>("salary") descending 
                    select new
                    {
                      Id = employee.Field<int>("Id"),
                      Name = employee.Field<string>("Name"),
                      Age = employee.Field<int>("Age"),
                      Department = employee.Field<string>("Department"),
                      Salary = employee.Field<int>("Salary")  
                    };


        //execute query
        //display the result of the linq query

        foreach (var item in query)
        {
            Console.WriteLine("Id: {0}, Name: {1},  Age: {2}, Departement: {3} ,Salary {4}",item.Id,item.Name,item.Age,item.Department,item.Salary);
        }

    }
}
public class Student
{
    public int StudentId { get; set; }
    public required string StudentName { get; set; }

    public int StudentAge {get;set;}
}


public class Employee : DataTable
{
    public Employee()
    {
        this.Columns.Add("Id",typeof(int));
        this.Columns.Add("Name",typeof(string));
        this.Columns.Add("Age",typeof(int));
        this.Columns.Add("Department",typeof(string));
        this.Columns.Add("Salary",typeof(int));
    }
}

