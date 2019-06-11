using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationApplication.Models
{

    public class Donor
    {
        public int DonorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Jmbg { get; set; }
        public KrvnaGrupa KrvnaGrupa { get; set; }
        public string BrojMobilnogTelefona { get; set; }
        public string Grad { get; set; }
        public List<Pregled> Pregledi { get; set; }
       
        //nisam dodala atribut zavod za patern??

    }
}

