using System;
using System.Collections.Generic;
using System.Text;

namespace EduSoft.core.Domain.Models
{
    public class Khoas
    {
        public string Id { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public Khoas()
        {
            NgayTao = DateTime.Now;
            NgayCapNhat = null;
            IsDelete = false;
            IsActive = true;
        }
    }
}
