using System;

namespace DTO
{
    public class LoaiTinDTO
    {
        public int id { get; set; }
        public int idTheLoai { get; set; }
        public string Ten { get; set; }
        public string TenKhongDau { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public Nullable<short> status { get; set; }

        public virtual TheLoaiDTO theloai { get; set; }
    }
}