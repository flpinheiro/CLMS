using System;
using System.Collections.Generic;
using System.Text;

namespace CLMS.Models
{
    public abstract class User
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public ICollection<Address> Addresses { get; set; }
        public ICollection<Phone> Phones { get; set; }

        public User()
        {
            Addresses = new HashSet<Address>();
            Phones = new HashSet<Phone>();
        }
    }
}
