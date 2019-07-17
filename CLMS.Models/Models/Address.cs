using System;
using System.Collections.Generic;
using System.Text;

namespace CLMS.Models
{
    public class Address
    {
        public uint Id { get; set; }
        public uint ZipCode { get; set; }
        public uint Number { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Complement { get; set; }

        public uint UserId { get; set; }
        public User User { get; set; }

    }
}
