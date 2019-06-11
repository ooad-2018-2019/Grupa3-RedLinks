using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationApplication.Models
{
    public class Pregled
    {
        public int PregledId { get; set; }
        public DateTime DatumPregleda { get; set; }
        public string DetaljiPregleda { get; set; }
        public bool UspjesanPregled { get; set; }
        public LaboratorijskiNalaz LabNalazId { get; set; }
      

    }
}
