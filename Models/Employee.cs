using System;
using System.Collections.Generic;

#nullable disable

namespace webapi.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Salary { get; set; }
    }
}
