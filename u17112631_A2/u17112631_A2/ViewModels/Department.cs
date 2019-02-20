using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using u17112631_A2.Models;

namespace u17112631_A2.ViewModels
{
    public class Department
    {
        public string name { get; set;}
        public decimal number { get; set; }
        public decimal totalSalaryExpense { get; set; }
        public List<Employee> employees;
        public HardwareDBEntities2 db;
       

        public Department(string name_,decimal num_, HardwareDBEntities2 db_)
        {
            name = name_;
            number = num_;
            employees = new List<Employee>();
            db = db_;
            totalSalaryExpense = 0;
            loadEmployees();
        }

        public void loadEmployees()
        {
            var empList = db.lgemployees.Where(x => x.dept_num == number).ToList();

            foreach(var emp in empList)
            {
                Employee newEmp = new Employee(db,emp.emp_num,emp.emp_fname,emp.emp_lname,emp.emp_title);
                totalSalaryExpense += newEmp.totalSalaryReceived;
                employees.Add(newEmp);
            }
        }

        public int getEmployeeCount()
        {
            return employees.Count;
        }

        public decimal getTotalDeptSalariesBetween(DateTime fromDate,DateTime toDate)
        {
            decimal totalSal = 0;
            foreach(Employee emp in employees)
            {
                totalSal += emp.getSalaryBetween(fromDate, toDate);
            }
            totalSalaryExpense = totalSal;
            return totalSal;
        }
    }
}