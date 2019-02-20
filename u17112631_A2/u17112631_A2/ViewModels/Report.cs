﻿using System;
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

        public Report()
        {

        }

        public void setDepartments(List<Department> deps)
        {
            departments = deps;
        }

    }
}