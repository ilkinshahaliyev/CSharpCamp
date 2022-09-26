namespace OOPPart3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationManager applicationManager = new();

            ICar mercedes = new Mercedes();
            ICar bMW = new BMW();
            ICar audi = new Audi();
            ICar ferrari = new Ferrari();

            ILoggerService databaseLogger = new DatabaseLoggerService();
            ILoggerService fileLogger = new FileLoggerService();
            ILoggerService smsLogger = new SMSLoggerService();

            List<ICar> cars = new List<ICar>() { mercedes, audi, bMW };
            applicationManager.DoCarPreInformation(cars);

            Console.WriteLine("-----------------------------------------------------------------");

            List<ILoggerService> loggerServices = new List<ILoggerService> { databaseLogger, smsLogger };

            applicationManager.DoApplication(mercedes, databaseLogger);
            applicationManager.DoApplication(ferrari, smsLogger);
            applicationManager.DoApplication(audi, fileLogger);

            Console.WriteLine("-----------------------------------------------------------------");

            applicationManager.DoApplication(ferrari, loggerServices);
        }
    }
}
