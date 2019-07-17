using System;
using System.Collections.Generic;
using System.Text;

namespace CLMS.Models
{
    public enum PhoneType { Mobile, Residence }
    public class Phone
    {
        public uint Id { get; set; }
        public ushort CountryCode { get; set; }
        public ushort AreaCode { get; set; }
        public uint Number { get; set; }
        public PhoneType Type { get; set; }

        public uint UserId { get; set; }
        public User User { get; set; }
    }
}
