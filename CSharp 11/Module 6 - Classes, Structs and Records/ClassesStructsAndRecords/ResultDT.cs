using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords
{
    internal class ResultDT
    {
        public int Value { get; set; }
        public int Doubled { get; set; }
        public int Tripled { get; set; }

        internal void Deconstruct(out int value, out int doubled, out int tripled)
        {
            value = Value;
            doubled = Doubled;
            tripled = Tripled;
        }
    }
}
