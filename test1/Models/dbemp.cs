using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace test1.Models
{
    [Table("emp")]
    public class dbemp
    {
        [Key]
        public int emp_id { get; set; }
        public string emp_name { get; set; }
    }
}