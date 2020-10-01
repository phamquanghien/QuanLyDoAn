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
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [StringLength(256)]
        [Required(ErrorMessage = "Confirm Password is required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirm password does not match.")]
        [NotMapped]
        public string ConfirmPassWord { get; set; }

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
