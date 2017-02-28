﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
