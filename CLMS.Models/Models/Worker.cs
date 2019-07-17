using System;
using System.Collections.Generic;
using System.Text;

namespace CLMS.Models
{
    class Worker : User 
    {
        public ServiceStation ServiceStation { get; set; }
    }
}
