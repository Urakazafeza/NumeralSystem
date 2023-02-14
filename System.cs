using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NumeralSystem
{
    internal class System
    {
        [Serializable]
        internal class IndexOutOfRangeException : Exception
        {
            public IndexOutOfRangeException()
            {
            }

            public IndexOutOfRangeException(string? message) : base(message)
            {
            }

            public IndexOutOfRangeException(string? message, Exception? innerException) : base(message, innerException)
            {
            }

            protected IndexOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
}
