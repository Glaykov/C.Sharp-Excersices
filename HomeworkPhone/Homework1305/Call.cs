using System;

namespace Homework1305
{
    public class Call
    {
        public static decimal PricePerMinute { get; set; }

        public GSM Caller { get; set; }

        public GSM Receiver { get; set; }
        
        public double Duration { get; set; }

        public Call(GSM caller, GSM receiver, double duration) {
            this.Caller = caller;
            this.Receiver = receiver;
            this.Duration = duration;
        }
    }
}
