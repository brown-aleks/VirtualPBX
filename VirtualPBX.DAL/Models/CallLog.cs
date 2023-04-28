using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPBX.DAL.Models
{
    public class CallLog
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int OutgoingCallKey { get; set; }
        public required Phone OutgoingCall { get; set; }
        public int IncomingCallKey { get; set; }
        public required Phone IncomingCall { get; set; }
        public TimeOnly CallDuration { get; set; }
    }
}
