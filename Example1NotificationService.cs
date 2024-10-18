using System;

namespace Solid_Principles_Lessons
{
    public class Example1NotificationService
    {
        public static class EmailService
        {
            public static void SendEmail(string To, string Message)
            {
                Console.WriteLine($"\n Sending Email To {To} , Message : {Message}");
            }
        }

        public static class SMSService
        {
            public static void SendSMS(string To, string Message)
            {
                Console.WriteLine($"\n Sending SMS To {To} , Message : {Message}");
            }
        }

        public static class FaxService
        {
            public static void SendFax(string To, string Message)
            {
                Console.WriteLine($"\n Sending Fax To {To} , Message : {Message}");
            }
        }

        public static class NotificationServices
        {
            public enum enNotificationTypes { Email, SMS, Fax };

            public static void SendNotification(string To, string Message, enNotificationTypes NotificatoinType)
            {
                switch (NotificatoinType)
                {
                    case enNotificationTypes.Email:

                        EmailService.SendEmail(To, Message);
                        break;

                    case enNotificationTypes.SMS:

                        SMSService.SendSMS(To, Message);
                        break;

                    case enNotificationTypes.Fax:

                        FaxService.SendFax(To, Message);
                        break;
                }
            }

        }

        static void Main(string[] args)
        {
            NotificationServices.SendNotification("zaka@gmail.com", "Valid Email", NotificationServices.enNotificationTypes.Email);

            NotificationServices.SendNotification("098982392392", "Hi Brother Zakaria How Are You", NotificationServices.enNotificationTypes.SMS);

            NotificationServices.SendNotification("0434023290", "Hello", NotificationServices.enNotificationTypes.Fax);

            Console.ReadKey();

        }
    }
}
