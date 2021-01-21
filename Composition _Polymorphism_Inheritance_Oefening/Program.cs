using System;
using System.Collections.Generic;

namespace Composition__Polymorphism_Inheritance_Oefening
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Maak een app (Mag een Console App zijn) die een bepaalde actie doet, zoals bv. videoverwerking (in pseudo-code)
                Een gebruiker kan zich op verschillende bronnen abonneren om een melding te krijgen wanneer een actie voltooid is.
                
            Een notification channel heeft een methode Send zonder body die derived classes MOETEN implementeren .
                Bij communicatiekanalen denk je bv aan een sms, een email, een toast notificatie etc.
                
            De verwerker klasse heeft  een methode Process en maakt gebruikt van een lijst van communicatiekanalen om een bericht naar te verzenden als de actie klaar is.
                
            Maak gebruik van compositie, inheritance en polymorphisme om dit zo loosely coupled mogelijk te maken
             * 
             * */
            var kanalen = new List<NotificationChannel>();
            kanalen = VoegKanalenToe();
            
            Verwerker verwerker = new Verwerker(kanalen);
            
            verwerker.Process();

            Console.ReadLine();
        }

        private static List<NotificationChannel> VoegKanalenToe()
        {
            var kanalen = new List<NotificationChannel>();
            kanalen.Add(new SmsChannel());
            kanalen.Add(new MailChannel());
            kanalen.Add(new RooksignaalChannel());

            return kanalen;
        }
    }
}
