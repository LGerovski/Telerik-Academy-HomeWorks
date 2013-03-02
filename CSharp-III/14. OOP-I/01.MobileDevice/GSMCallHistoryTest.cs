using System;

namespace MobileDevice
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            GSM nokia = new GSM("E-65", "Nokia");
            nokia.AddCall("0889186005", 237);
            nokia.AddCall("0889182205", 114);
            nokia.AddCall("0889346005", 87);
            nokia.AddCall("0889346108", 111);
            nokia.DisplayCallInformation();
            Console.WriteLine("Current bill for this number {0} Leva.\n", nokia.GetCallsPrice(0.37m));
            nokia.RemoveCall();
            nokia.DisplayCallInformation();
            nokia.ClearCallHistory();
            nokia.DisplayCallInformation();
        }
    }
}
