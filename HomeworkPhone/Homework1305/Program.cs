using System;

namespace Homework1305
{
    public class Program
    {
        static void Main(string[] args)
        {
            Call.PricePerMinute = 0.32m;
            GSM firstPhone = new GSM("Huawei");
            GSM secondPhone = new GSM("Nokia");
            GSM thirdPhone = new GSM("Samsung");
            GSM fourthPhone = new GSM("Xiaomi");
            GSM fifthPhone = new GSM("Lenovo");
            
            firstPhone.InsertSimCard("0895746790");
            secondPhone.InsertSimCard("0876224421");
            thirdPhone.InsertSimCard("0876412279");
            fourthPhone.InsertSimCard("4433587575");
            fifthPhone.InsertSimCard("5234449878");

            firstPhone.MakeCall(secondPhone, 25.5);
            secondPhone.MakeCall(thirdPhone, 35.5);
            thirdPhone.MakeCall(firstPhone,12.4);
            fourthPhone.MakeCall(fifthPhone, 125);
            
            firstPhone.LastOutGoingCallInfo();
            secondPhone.LastOutGoingCallInfo();
            thirdPhone.LastOutGoingCallInfo();
            fourthPhone.LastOutGoingCallInfo();
            fifthPhone.LastIncomingCallInfo();

            firstPhone.LastIncomingCallInfo();
            secondPhone.LastIncomingCallInfo();
            thirdPhone.LastIncomingCallInfo();
            fourthPhone.LastIncomingCallInfo();
            fifthPhone.LastIncomingCallInfo();
            
            firstPhone.PhoneTax();
            secondPhone.PhoneTax();
            thirdPhone.PhoneTax();
            fourthPhone.PhoneTax();
            fifthPhone.PhoneTax();
            
            Console.ReadKey();
        }
    }

}
