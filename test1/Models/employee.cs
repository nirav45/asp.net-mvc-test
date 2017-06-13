using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace test1.Models
{
    public class employee
    {

        public employee()
        {
            this.details = new List<employee>();
        }
        public int emp_id {get; set;}
        public string emp_name { get; set; }

        public List<employee> details { get; set; }
    }

    public class empcontext: DbContext
    {
        public DbSet<dbemp> empDB { get; set; }
    }
}