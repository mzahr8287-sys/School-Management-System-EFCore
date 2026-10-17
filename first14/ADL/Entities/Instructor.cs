using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace first14.ADL.Entities
{
    internal class Instructor
    {
        [Key]
        public int InsID { get; set; }
        [Column(TypeName ="nvarchar(30)")]
        public string InsName { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }
        public Department ManagedDepartment { get; set; }
        public int DepartmentID { get; set; }
        public Department department { get; set; }
        public List<CourseInstructor> CourseInstructor { get; set; }
    }
}
