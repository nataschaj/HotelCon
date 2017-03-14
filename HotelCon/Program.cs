using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCon
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new HotelContext())
            {

                var hotelList =
                    from nyhotel in db.Hotel
                    select nyhotel;

                Console.WriteLine("List alle oplysninger om hoteller: ");
                foreach (var nyhotel in hotelList)
                {
                    Console.WriteLine(nyhotel.ToString());
                }

                Console.WriteLine();

                var guestList =
                    from nyguest in db.Guest
                    select nyguest;

                Console.WriteLine("List alle oplysninger om kunderne: ");
                foreach (var nyguest in guestList)
                {
                    Console.WriteLine(nyguest.ToString());
                }



                db.SaveChanges();

            }

            Console.ReadLine();

        }
    }
}
