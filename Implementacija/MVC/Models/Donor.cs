﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationApplication.Models
{

    public class Donor
    {
        public int DonorId { get; set; }

        [DisplayName("Ime")]
        public string Ime { get; set; }

        [DisplayName("Prezime")]
        public string Prezime { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("JMBG")]
        public string Jmbg { get; set; }

        [DisplayName("Krvna grupa")]
        public KrvnaGrupa KrvnaGrupa { get; set; }

        [DisplayName("Broj mobilnog telefona")]
        public string BrojMobilnogTelefona { get; set; }

        [DisplayName("Mjesto prebivališta(grad)")]
        public string Grad { get; set; }
        public List<Pregled> Pregledi { get; set; }
       
        //nisam dodala atribut zavod za patern??

    }
}

