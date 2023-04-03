namespace PW4._2
{
    class Package
    {
        public string PackageDiscription { get; private set; }
        public double Weight { get; private set; }

        public Package(string packageDiscription, double weight)
        {
            PackageDiscription = packageDiscription;
            Weight = weight;
        }
    }

    class DeliveryService
    {
        public double WeightLimit { get; private set; }

        public DeliveryService(double weightLimit)
        {
            WeightLimit = weightLimit;
        }

        public void SendPackage(Package package)
        {
            if (package.Weight >= WeightLimit)
            {
                Console.WriteLine($"Вес посылки слишком велик, он равен: {package.Weight}, а лимит равен: {WeightLimit}");
            }
            else
            {
                Console.WriteLine($"Ваша посылка {package.PackageDiscription} с весом {package.Weight} успешно отправлена!");
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            DeliveryService KrestinenkoDelivery = new DeliveryService(150);

            Package firstPack = new Package("Новый монитор для ПаШкА ЕмЕлЬяНоВа", 20);
            Package secondPack = new Package("", 250);

            KrestinenkoDelivery.SendPackage(firstPack);
            KrestinenkoDelivery.SendPackage(secondPack);
        }
    }
}