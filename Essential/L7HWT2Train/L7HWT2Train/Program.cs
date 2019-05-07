using System;
using System.Collections.Generic;
using Common;
namespace L7HWT2Train
{
    internal class Program
    {
        private static void ShowAllTrains(IReadOnlyList<Train> train)
        {
            Console.WriteLine("List of trains: ");
            for (var i = 0; i < train.Count; ++i)
            {
                ConsoleExtension.ClearExcess(5);
                Console.WriteLine($"\nTrain № {i+1}:");
                Console.WriteLine($"Destination: {train[i].Destination}\nTrain number: {train[i].TrainNumber}\nDeparture time: {train[i].DepartureTime}");
            }
            ConsoleExtension.WaitingAction();
        }

        private static void ShowTrainByNumber(Train train)
        {
            Console.WriteLine("\nYour train:");
            Console.WriteLine(
                $"Destination: {train.Destination}" +
                $"\nTrain number: {train.TrainNumber}" +
                $"\nDeparture time: {train.DepartureTime}");
            ConsoleExtension.WaitingAction();
        }

        private static int CheckNumberOfTrain()
        {
            var numberOfTrains = ConsoleExtension.CheckInt();
            if (numberOfTrains <= 8) return numberOfTrains;
            Console.WriteLine("Exceeded maximum number of trains!");
            numberOfTrains = 8;
            ConsoleExtension.WaitingAction();

            return numberOfTrains;
        }

        private static void CreateArrayOfTrains(IList<Train> train)
        {
            Console.Write("How many trains u want to add manual? (max value = 8 trains) - ");
            var numberOfTrains = CheckNumberOfTrain();
            if (numberOfTrains != train.Count)
            {
                Console.WriteLine($"\n{train.Count - numberOfTrains} trains will have default values!\n");
                ConsoleExtension.WaitingAction();
            }
            for (var i = 0; i < train.Count; i++)
            {
                if (i >= numberOfTrains)
                {
                    var j = i + 1;
                    train[i] = new Train($"Destination {j}", j, $"0{j}:00");
                    continue;
                }
                Console.Clear();
                Console.WriteLine($"Enter train №{i+1}");
                Console.Write("\nEnter destination - ");
                var destination = Console.ReadLine();
                Console.Write("Enter train number - ");
                var trainNumber = ConsoleExtension.CheckInt();
                Console.Write("Enter departure time - ");
                var departureTime = Console.ReadLine();
                train[i] = new Train(destination, trainNumber, departureTime);
            }
        }

        private static void Main()
        {
            var train = new Train[8];
            CreateArrayOfTrains(train);
            var body = new[]
            {
                "Menu:", "Search train by number", "Show all trains"
            };
            do
            {
                var menuSelect = Menu.CreateMenuInt(body);
                switch (menuSelect)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Enter number of your train - ");
                        var trainNumberForSearch = ConsoleExtension.CheckInt() - 1;
                        if (trainNumberForSearch > 8)
                        {
                            Console.WriteLine("Error!");
                            ConsoleExtension.WaitingAction();
                            break;
                        }
                        ShowTrainByNumber(train[trainNumberForSearch]);
                        break;
                    case 2:
                        Console.Clear();
                        ShowAllTrains(train);
                        break;
                }
            } while (true);
        }
    }
}
