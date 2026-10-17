using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace first14.ADL.Entities
{
    internal class Department
    {
        [Key]
        public int DID { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string DName { get; set; }

        public int? ManagerId { get; set; } 
        public Instructor Manager { get; set; }
        public DateTime? HireDate { get; set; }
        public List<Instructor> Instructors {  get; set; }
        public List<Student> Students { get; set; }
     }
}
