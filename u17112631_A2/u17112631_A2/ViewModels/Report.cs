using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u17112631_A2.ViewModels
{
    public class Report
    {
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }

        public List<Department> departments;

        public Dictionary<string, decimal> chartData;
        public Report()
        {
            chartData = new Dictionary<string, decimal>();
        }

        public void setDepartments(List<Department> deps)
        {
            departments = deps;

            foreach(var dept in departments)
            {
                chartData.Add(dept.name, dept.getTotalDeptSalariesBetween(fromDate,toDate));
            }
        }

        public void updateDept()
        {
            chartData.Clear();
            foreach (var dept in departments)
            {
                chartData.Add(dept.name, dept.getTotalDeptSalariesBetween(fromDate, toDate));
            }
        }

    }
}