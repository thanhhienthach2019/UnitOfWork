using System.Collections.Generic;

namespace DTO
{
    public class DonViDTO
    {
        public string MS_DV { get; set; }
        public string TenDonVi { get; set; }
        public string VietTat { get; set; }
        public virtual ICollection<UserDTO> users { get; set; }
    }
}