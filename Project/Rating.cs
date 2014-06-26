using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Rating
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public virtual Account OwnerAccount { get; set; }
        public virtual InfoBlock OwnerInfoBlock { get; set; }

    }
}
