using System;
using System.Collections.Generic;

namespace DTO
{
    public class TheLoaiDTO
    {
        public int id { get; set; }
        public string Ten { get; set; }
        public string TenKhongDau { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public Nullable<short> status { get; set; }
        public virtual ICollection<LoaiTinDTO> loaitins { get; set; }
    }
}