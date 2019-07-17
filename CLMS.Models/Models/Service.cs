using System;
using System.Collections.Generic;
using System.Text;

namespace CLMS.Models
{
    class Service
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public decimal Penalty { get; set; }
    }
}
