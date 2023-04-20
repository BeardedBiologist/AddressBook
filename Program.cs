using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// BREIF
//
// Create a class that has properties for street address, city, state, and
// zip code. Then add a FullAddress property that is read-only.

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AddressModel> completeAddress = new List<AddressModel>();
            bool okToClose = true;

            while (okToClose)
            {
                string streetAddress = ProcessAddress.GetAString("What is the street address? -- OR type 'EXIT' to quit: ");

                if (streetAddress.ToLower() != "exit")
                {
                    string city = ProcessAddress.GetAString("What is the city?: ");
                    string state = ProcessAddress.GetAString("What is the state?: ");
                    string zipcode = ProcessAddress.GetAString("What is the zipcode?: ");

                    AddressModel address = new AddressModel();
                    address.StreetAddress = streetAddress;
                    address.City = city;
                    address.State = state;
                    address.Zipcode = zipcode;

                    completeAddress.Add(address);
                    Console.Clear();
                }
                else
                {
                    okToClose = false;
                    break;
                }
            }

            foreach (AddressModel a in completeAddress)
            {
                ProcessAddress.ConcatAddress(a);
            }
        }
    }
}