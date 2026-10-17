using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace first14.ADL.Entities
{
    internal class Topic
    {
        
        public int ID { get; set; }
        [Column(TypeName ="nvarchar(30)")]
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
