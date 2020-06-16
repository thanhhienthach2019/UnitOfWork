using System;

namespace DTO
{
    public class BanhanhvbDTO
    {
        public System.Guid Id { get; set; }
        public System.Guid Idvanban { get; set; }
        public string Donvinhan { get; set; }
        public Nullable<System.DateTime> Ngayphathanh { get; set; }
        public string Nguoibanhanh { get; set; }

        public virtual VanBanDTO vanban { get; set; }
    }
}