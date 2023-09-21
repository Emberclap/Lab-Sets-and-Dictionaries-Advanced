using System.Security.Cryptography;

namespace _7._Parking_Lot
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> parkingLot = new HashSet<string>();

            while (input[0] != "END")
            {
                if (input[0] == "IN")
                {
                    parkingLot.Add(input[1]);
                }
                else
                {
                    parkingLot.Remove(input[1]);
                }
                input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }
            if (parkingLot.Count > 0)
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else 
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}