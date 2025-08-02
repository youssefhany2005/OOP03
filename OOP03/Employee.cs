using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP03
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public security_level SecurityLevel { get; set; }
        public double Salary;
        public Hiring_Date HiringDate { get; set; }

        public Employee(int _id, string _name, Gender _gender, Hiring_Date _HiringDate, security_level _securityLevel, double _salary)
        {
            Id = _id;
            Name = _name;
            Gender = _gender;
            HiringDate = _HiringDate;
            SecurityLevel = _securityLevel;
            Salary = _salary;
        }

        public override string ToString()
        {
            //عشان اعرض السالاري علي شكل currency => cultureInfo.CurrentCulture
            return $"ID : ({Id}) \n Name : ({Name}) \n Gender : ({Gender}) \n Security Level : ({SecurityLevel})\n Salary : ({Salary.ToString("C", CultureInfo.CurrentCulture)})\n Hiring Date : ({HiringDate})";
        }
    }
}
