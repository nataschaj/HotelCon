﻿using System;
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
               
                

                db.SaveChanges();

            }

        }
    }
}
