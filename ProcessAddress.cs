using System;
namespace AddressBook
{
	public class ProcessAddress
	{
        public static string GetAString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();
            return output;
        }


        public static void ConcatAddress(AddressModel address)
        {
            Console.WriteLine($"The address you have given is: " +
                $"{address.StreetAddress}, {address.City}, {address.State}, " +
                $"{address.Zipcode}");
        }
    }
}

