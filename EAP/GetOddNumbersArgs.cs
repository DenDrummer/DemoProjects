using System;

namespace EAP
{
    public delegate void GetOddNumbersHandler(object sender, GetOddNumbersArgs e);

    public class GetOddNumbersArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        public GetOddNumbersArgs(Exception ex, bool canceled, object userState) : base(ex, canceled, userState)
        {

        }
    }
}
