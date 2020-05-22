using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiLieuDTO
    {
        public int id { get; set; }
        public string TieuDe { get; set; }
        public string TenFile { get; set; }
        public string FilePath { get; set; }
        public Nullable<System.DateTime> create_at { get; set; }
        public Nullable<System.DateTime> create_up { get; set; }
        public Nullable<short> status { get; set; }
        public string user_create { get; set; }
        public string MaSo { get; set; }
        public string MS_DV { get; set; }
        public string MaLoai { get; set; }

        public virtual UserDTO user { get; set; }
    }
}
