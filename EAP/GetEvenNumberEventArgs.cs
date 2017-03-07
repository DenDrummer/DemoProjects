using System;

namespace EAP
{
    public delegate void GetEvenNumbersHandler(object sender, GetEvenNumberEventArgs e);

    public class GetEvenNumberEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        //Error: Any exception occured during the operation
        //Canceled: Whether the operation canceled before it complete
        //userState: Any user object (may be sum result expected from the method)
        public GetEvenNumberEventArgs(Exception ex, bool canceled, object userState) : base(ex, canceled, userState)
        {

        }
    }
}
