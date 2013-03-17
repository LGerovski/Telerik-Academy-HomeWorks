using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CustomException
{
    class InvalidRangeException<T> : ApplicationException
    {
        public T Start { get; set; }
        public T End { get; set; }

        public InvalidRangeException(T start, T end) : this(start, end, null)
        {
        }
        public InvalidRangeException(T start, T end, string message) : this(start, end, message, null)
        {
        }
        public InvalidRangeException(T start, T end, string message, Exception innerException)
            : base(message, innerException)
        {
            this.Start = start;
            this.End = end;
        }
    }
}
