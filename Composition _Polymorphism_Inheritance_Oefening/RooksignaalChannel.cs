using System;
using System.Collections.Generic;
using System.Text;

namespace Composition__Polymorphism_Inheritance_Oefening
{
    class RooksignaalChannel : NotificationChannel
    {
        public override void Send()
        {
            Console.WriteLine($"Rooksignaal: {Message}");
        }
    }
}
