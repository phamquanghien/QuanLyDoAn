using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyDoAn.Models
{
    [Table("Teachers")]
    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public int LimitedAmount { get; set; }
        public string Department { get; set; }
        public string WorkPlace { get; set; }
    }
}