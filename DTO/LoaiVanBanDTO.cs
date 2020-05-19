using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiVanBanDTO
    {
        public int id { get; set; }
        public string TenLoaiVB { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public string UserCreate { get; set; }
        public Nullable<System.DateTime> DateUpdate { get; set; }
        public virtual ICollection<VanBanDTO> vanbans { get; set; }
    }
}
