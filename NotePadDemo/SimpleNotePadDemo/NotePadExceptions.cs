using System;

namespace NotePad
{
    public class NotepadExceptions:Exception
    {
        public int PageIndex { get; set; }
        public string Name { get; set; }
        public int Index { get; set; }
        public string MethodName { get; set; }

        public NotepadExceptions(string methodName,int i) : base($"\n{methodName}Method unavailabe for SecureNotepad") {
            MethodName = methodName;
        }

        public NotepadExceptions(int index):base($" \nEmpty Page --{index}--") {
            Index = index;
        }

        public NotepadExceptions(int pageIndex,string message):base("\n"+message) {
            PageIndex = pageIndex;
        }

        public NotepadExceptions(string secureNorepadName):base($"Wrong Password for {secureNorepadName}") {
            Name = secureNorepadName;   
        }
    }
}
