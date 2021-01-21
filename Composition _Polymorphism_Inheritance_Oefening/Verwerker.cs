using System;
using System.Collections.Generic;
using System.Text;

namespace Composition__Polymorphism_Inheritance_Oefening
{
    class Verwerker
    {        
        List<NotificationChannel> kanalen = new List<NotificationChannel>();
        
        Random random = new Random();

        public Verwerker(List<NotificationChannel> lijst)
        {
            kanalen = lijst;
            
        }
        
        public void Process()
        {
            Console.WriteLine("Start Process\n");
            System.Threading.Thread.Sleep(2000); //pseudoprocess

            if(random.Next(1,4) == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                SendNotifications("Process is Mislukt");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                SendNotifications("Process is afgerond");
                Console.ResetColor();
            }            
        }

        public void SendNotifications(string message)
        {
            foreach (var kanaal in kanalen)
            {
                kanaal.Message = message;
                kanaal.Send();
            }            
        }

        
    }
}
