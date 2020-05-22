using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiTaiLieuDTO
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public Nullable<System.DateTime> Create_at { get; set; }
        public string User_create { get; set; }
    }
}
