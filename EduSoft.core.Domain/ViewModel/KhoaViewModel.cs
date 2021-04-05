using System;
using System.Collections.Generic;
using System.Text;

namespace EduSoft.core.Domain.ViewModel
{
    public class KhoaViewModel
    {
        public string Id { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}
