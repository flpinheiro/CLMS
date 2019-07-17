using System;
using System.Collections.Generic;
using System.Text;

namespace CLMS.Models
{
    class ServiceStation
    {
        public uint Id { get; set; }
        public ICollection<Worker> Workers { get; set; }
        public ServiceStation()
        {
            Workers = new HashSet<Worker>();
        }
    }
}
