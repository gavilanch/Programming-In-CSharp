using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    internal class HideAttribute: Attribute
    {
        // The types we can pass as params: Byte, Short, Integer, Long, Single, Double, Char,
        // String, Boolean, System.Type, or an enum.

        DateTime Begin { get; }
        DateTime End { get; }
        private bool useRangeDate = false;

        public HideAttribute(int yearBegin, int monthBegin, int dayBegin, int yearEnd, int monthEnd, int dayEnd)
        {
            Begin = new DateTime(yearBegin, monthBegin, dayBegin);
            End = new DateTime(yearEnd, monthEnd, dayEnd);
            useRangeDate = true;
        }

        public HideAttribute()
        {

        }

        public bool Hide()
        {
            if (useRangeDate)
            {
                return DateTime.Now >= Begin && DateTime.Now <= End;
            }
            else
            {
                return true;
            }
        }

    }
}
