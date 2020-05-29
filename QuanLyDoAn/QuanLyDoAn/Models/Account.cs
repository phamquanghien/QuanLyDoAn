using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace QuanLyDoAn.Models
{
    public partial class Account
    {
        [Key]
        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(256)]
        public string Password { get; set; }

        public string Email { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreationTime { get; set; }

        public bool? EmailConfirmed { get; set; }

        public bool? IsDelete { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DeleteTime { get; set; }

        [StringLength(50)]
        public string RoleID { get; set; }
    }
}
