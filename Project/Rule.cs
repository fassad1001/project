using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Rule
    {
        public int Id { get; private set; }
        public virtual InfoBlock OwnerInfoBlock { get; private set; }
        public string Begin { get; private set; }
        public string End { get; private set; }
        public string Target { get; private set; }
    }
}
