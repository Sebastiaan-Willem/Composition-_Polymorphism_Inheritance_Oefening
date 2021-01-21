using System;
using System.Collections.Generic;
using System.Text;

namespace Composition__Polymorphism_Inheritance_Oefening
{
    public abstract class NotificationChannel 
    {
        public string Message { get; set; }
        public abstract void Send();
    }
}
