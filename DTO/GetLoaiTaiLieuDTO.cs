using System;

namespace DTO
{
    public class GetLoaiTaiLieuDTO
    {
        public Nullable<long> STT { get; set; }
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public Nullable<System.DateTime> Create_at { get; set; }
    }
}