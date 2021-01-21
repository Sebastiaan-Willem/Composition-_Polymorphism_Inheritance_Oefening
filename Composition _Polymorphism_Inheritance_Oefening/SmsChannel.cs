using System;
using System.Collections.Generic;
using System.Text;

namespace Composition__Polymorphism_Inheritance_Oefening
{
    class SmsChannel : NotificationChannel
    {
        public override void Send()
        {
            Console.WriteLine($"Sms: {Message}");
        }
    }
}
