using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistry.Models
{
    public class User
    {
        public int UserID { get; set; }
        public int RegisterID { get; set; }

        public Register Register { get; set; }
    }
}
