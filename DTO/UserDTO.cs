using System;
using System.Collections.Generic;

namespace DTO
{
    public class UserDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public string donvi { get; set; }

        public virtual DonViDTO DonVi1 { get; set; }
        public virtual ICollection<TaiLieuDTO> tailieux { get; set; }
    }
}