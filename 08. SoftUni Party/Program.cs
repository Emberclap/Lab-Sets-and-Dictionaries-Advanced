namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guests = "";
            HashSet<string> guestList = new HashSet<string>();
            //HashSet<string> regularList = new HashSet<string>();
            while ((guests = Console.ReadLine()) != "PARTY") 
            {
                guestList.Add(guests);
            }
            string arrivingGuests = "";
            while ((arrivingGuests = Console.ReadLine()) != "END")
            {
                guestList.Remove(arrivingGuests);
                
            }
            int missingGuests = guestList.Count;
            Console.WriteLine(missingGuests);
            foreach (var guest in guestList.OrderByDescending(c => char.IsDigit(c[0])))
            {
                Console.WriteLine(guest);
            }
            
        }
    }
}