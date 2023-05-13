using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata
{
    internal enum Actions
    {
        WriteTXT = 1,
        [Hide(yearBegin: 2024, monthBegin: 1, dayBegin: 1, yearEnd: 2024, monthEnd: 12, dayEnd: 31)]
        WriteXML = 2,
        WriteJSON = 3
    }
}
