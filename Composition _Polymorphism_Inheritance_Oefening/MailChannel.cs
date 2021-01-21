using System;
using System.Collections.Generic;
using System.Text;

namespace Composition__Polymorphism_Inheritance_Oefening
{
    class MailChannel : NotificationChannel
    {
        public override void Send()
        {
            Console.WriteLine($"Mail: {Message}");
        }
    }
}
