using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace apkakonsoli_final
{
    [DataContract]
    public class HourException : Exception
    {
        public HourException() { }
        public HourException(string message) : base(message) { }
    }
}
