using System;


namespace Homework1305
{
    public class GSM
    {
        public string Model { get; set; }

        public bool HasSimCard { get; set; }

        public string SimMobileNumber { get; set; }

        public double OutGoingCallsDuration { get; set; }

        public Call LastIncomingCall { get; set; }

        public Call LastOutgoingCall { get; set; }

        public decimal SumForCalls
        {
            get
            {
                return (decimal)OutGoingCallsDuration * Call.PricePerMinute;
            }
        }

        public GSM(string model)
        {
            this.Model = model;
        }

        public void InsertSimCard(string MobileNumber)
        {
            if (MobileNumber.Length == 10 && MobileNumber[0] == '0' && MobileNumber[1] == '8')
            {
                this.HasSimCard = true;
                this.SimMobileNumber = MobileNumber;
            }
            else
                Console.WriteLine("Number should start with '08...' and contain 10 digits.Try again...\n");
        }
        
        public void RemoveSimCard()
        {
            this.HasSimCard = false;
        }

        public void MakeCall(GSM receiver, double duration) {

            if (this.SimMobileNumber != receiver.SimMobileNumber)
            {
                if (this.HasSimCard == true && receiver.HasSimCard == true)
                {
                    if (duration > 0 && duration <= 120)
                    {
                        Call newCall = new Call(this, receiver, duration);
                        this.LastOutgoingCall = newCall;
                        receiver.LastIncomingCall = newCall;
                        this.OutGoingCallsDuration += duration;
                    }
                }
            }
            else
                Console.WriteLine($"Wrong number/No Sim Card/Invalid duration\n");
        }

        public void LastOutGoingCallInfo()
        {
            if (this.LastOutgoingCall == null || this.SimMobileNumber == null)
            {
                Console.WriteLine($"There is no last outgoing call OR no number assigned for this phone\n");
            }
            else
            {
                Console.WriteLine($"Info for last outgoing call for ''{this.SimMobileNumber}:'' " +
               $"\nLast called number is : {this.LastOutgoingCall.Receiver.SimMobileNumber}," +
                $"\nCall duration is : {this.LastOutgoingCall.Duration} minutes.\n");
            }
        }

        public void LastIncomingCallInfo()
        {
            if (this.LastIncomingCall == null || this.SimMobileNumber == null)
            {
                Console.WriteLine($"There is no last incoming call OR no number assigned for this phone\n");
            }
            else
            {
                Console.WriteLine($"Info for last incoming call for ''{this.SimMobileNumber}:''" +
               $"\nLast income call from : {this.LastIncomingCall.Caller.SimMobileNumber}," +
                $"\nCall duration is : {this.LastIncomingCall.Duration} minutes.\n");
            }
        }

        public void PhoneTax() {
            if (this.SimMobileNumber == null) {
                Console.WriteLine("No number assigned for this phone\n");
            }else
            Console.WriteLine($"Tax for {this.SimMobileNumber} is {Math.Round(this.SumForCalls,2)} leva.\n");
            }
    }
}


   

       




