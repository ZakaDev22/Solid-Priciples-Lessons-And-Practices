using System;

namespace Example2inC_Logging_Service
{
    internal class Program
    {

        public static class DatabaseLogServices
        {
            public static void Log(string message)
            {
                Console.WriteLine($"\n Success , Message With : {message} Was Saved Successfully in Your Database");
            }
        }

        public static class FilesLogServices
        {
            public static void Log(string message)
            {
                Console.WriteLine($"\n Success , Message With : {message} Was Saved Successfully in Your Files");
            }
        }

        public static class EventViewrLogServices
        {
            public static void Log(string message)
            {
                Console.WriteLine($"\n Success , Message With : {message} Was Saved Successfully in Your Event Viewer");
            }
        }

        public static class LogServices
        {
            public enum LogType { Files, Database, EventViewr }

            public static void Log(string Messgae, LogType type)
            {
                switch (type)
                {
                    case LogType.Files:

                        FilesLogServices.Log(Messgae);
                        break;

                    case LogType.Database:

                        DatabaseLogServices.Log(Messgae);
                        break;

                    case LogType.EventViewr:

                        EventViewrLogServices.Log(Messgae);
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            LogServices.Log("Zakaria ELfakhar", LogServices.LogType.Database);

            LogServices.Log("I have 22 Years And I will Be 23 In Th Next Feb 2025", LogServices.LogType.Files);

            LogServices.Log("Error, Null Ref Exception", LogServices.LogType.EventViewr);

            Console.ReadKey();
        }
    }
}
