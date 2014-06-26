using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class HistoryItem
    {
        public int Id { get; set; }
        public virtual InfoBlock OwnerInfoblock { get; set; }
        public virtual Account OwnerAccount { get; set; }
        public DateTime Date { get; set; }
    }
}
