namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            /*
            Employee[] Employees = new Employee[3];
            Employees[0] = new Employee(1, "Youssef", Gender.M, new Hiring_Date(2011, 2, 5), security_level.DBA, 1000.0);
            Employees[1] = new Employee(2, "Hany", Gender.M, new Hiring_Date(2023, 1, 4), security_level.Developer, 3330.0);
            Employees[2] = new Employee(3, "Mohammed", Gender.Male, new Hiring_Date(2025, 4, 3), security_level.Secretary, 2500.00);
            Employees[3] = new Employee(4, "Menna", Gender.Female, new Hiring_Date(2012, 5, 2), security_level.Guest, 5500.0);
            Employees[4] = new Employee(5, "Maha", Gender.F, new Hiring_Date(2009, 8, 1), security_level.DBA, 4500.0);

            Array.Sort(Employees); // معرفتش ارتب علي حسب التواريخ ازاي 
            foreach (Employee Emp in Employees)
            {
                Console.WriteLine(Emp);
            }
            */
            #endregion

            #region Part 02
            /*
            Book[] Books = new Book[2];
            Books[0] = new EBook("Physics", "Youssef Hany", "1234567890", 600.0);
            Books[1] = new PrintedBook("Chemistry", "Ashraf el Shenawy", "1234567891", 200);
            Books[2] = new EBook("Programming Basics", "Route Academy", "1234567892", 123.4);
            Books[3] = new PrintedBook("Biology", "Ahmed Ali", "1234567893", 340);
            Books[4] = new EBook("Discrete Mathematics", "AboTrika", "1234567894", 555.5);
            Books[5] = new PrintedBook("Operating System", "Ahmed Salah", "1234567895", 120);

            foreach (Book book in Books)
            {
                book.ToString();
                Console.WriteLine();
            } 
            */
            #endregion

        }
    }
}
