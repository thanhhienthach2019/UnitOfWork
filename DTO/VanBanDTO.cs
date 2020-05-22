using System;

namespace DTO
{
    public class VanBanDTO
    {
        public System.Guid Id { get; set; }
        public string Sovb { get; set; }
        public string Trichyeu { get; set; }
        public string Noidung { get; set; }
        public Nullable<System.DateTime> Ngaydang { get; set; }
        public string Nguoidang { get; set; }
        public Nullable<int> Idloaivb { get; set; }
        public string Url { get; set; }
        public string Donvigui { get; set; }
        public string TenFile { get; set; }

        public virtual LoaiVanBanDTO loaivanban { get; set; }
    }
}