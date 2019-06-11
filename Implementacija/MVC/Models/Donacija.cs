using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationApplication.Models
{
    public class Donacija
    {
        public int DonacijaId { get; set; }
        public DateTime DatumDonacije { get; set; }
   
        public Donor Donor { get; set; }
        public KomponenteKrvi DoniraneKolicine { get; set; }
        public double DoniranaKolicinaKrvi { get; set; }

    }
}
