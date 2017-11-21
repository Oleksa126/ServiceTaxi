using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ServiceTaxi.Repository;
using ServiceTaxi.Models;

namespace ServiceTaxiDAL
{
    public class Program
    {
        static void Main(string[] args)
        {

            User u1 = new User { Country = "Ukrain", FirstName = "Baza", ID = 454, LastName = "dfsc", PhoneNumber = "45" };
            
            using (var br = new DataBaseContext()) {

                //br.Users.Add(u1);
                //br.SaveChanges();
             



                foreach (var a in br.Users.ToList()) {
                    Console.WriteLine(a.ToString());
                }
            }



            Console.ReadKey();

    }
}
}
