using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using u17112631_A2.Models;

namespace u17112631_A2.ViewModels
{
    
    public class Employee
    {
        HardwareDBEntities db;
        public decimal employeeNumber { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string title { get; set; }

        public decimal totalSalaryReceived;
        public List<lgsalary_history> myPayCheques;

        public Employee(HardwareDBEntities db_,decimal empNum,string name_,string surname_,string title_)
        {
            db = db_;
            employeeNumber = empNum;
            name = name_;
            surname = surname_;
            title = title_;

            myPayCheques = db.lgsalary_history.Where(x => x.emp_num == employeeNumber).ToList();
            totalSalaryReceived = 0;
        }


        public decimal getTotalSalary()
        {
            totalSalaryReceived = 0;

            foreach (var salary in myPayCheques)
            {
                totalSalaryReceived += (decimal)salary.sal_amount;
            }

            return totalSalaryReceived;
        }

        public decimal getSalaryBetween(DateTime fromDate_, DateTime toDate_)
        {
            decimal salaryBetweenDates = 0;
            var paychequesBetweenDates = myPayCheques.Where(x => x.sal_from >= fromDate_ && x.sal_end <= toDate_).ToList();

            foreach (var salary in paychequesBetweenDates)
            {
                salaryBetweenDates += (decimal)salary.sal_amount;
            }

            return salaryBetweenDates;
        }
    }
}