﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MySMSApp.Model
{
    public class SmsModel
    {
        public ContactModel contact { get; set; }
        public string message { get; set; }
    }
}