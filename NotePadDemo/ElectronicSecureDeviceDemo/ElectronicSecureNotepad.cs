using NotePad;
using Secure;
using System;
using System.Runtime.CompilerServices;
using Secure;

namespace ElectronicSecureDeviceDemo
{
    public class ElectronicSecureNotepad : SecureNotepad,IElectronicDevice
    {

        public ElectronicSecureNotepad(string name,int pages,string pass):base(name,pages,pass) {
            
        
        }
        public bool IsStarted { get; private set; }

        public void Start()
        {
            if (this.IsStarted)
            {
                Console.WriteLine("The device is working...");
            }
            else
            {
                this.IsStarted = true;
            }
        }

        public void Stop()
        {
            if (!this.IsStarted)
            {
                Console.WriteLine("The device is not working...");

                return;
            }

            this.IsStarted = false;
        }


        public override void AddTxtToPage(string password, string text, int pageIndex)
        {
            if (this.IsStarted)
            {
                base.AddTxtToPage(password, text, pageIndex);
            }
            else Console.WriteLine("The device is not working...");
        }

        public override void ReplaceTxtFromPage(string password, string text, int pageIndex)
        {
            if (this.IsStarted)
            {
                base.ReplaceTxtFromPage(password, text, pageIndex);
            }else Console.WriteLine("The device is not working...");
        }

        public override void DeleteTxtFromPage(string password, int pageIndex)
        {
            if (this.IsStarted)
            {
                base.DeleteTxtFromPage(password,pageIndex);
            }
            else Console.WriteLine("The device is not working...");
        }

        public override void PreviewPage(string password, int pageIndex)
        {
            if (this.IsStarted)
            {
                base.PreviewPage(password, pageIndex);
            }else Console.WriteLine("The device is not working...");
        }
        

        
    }
}