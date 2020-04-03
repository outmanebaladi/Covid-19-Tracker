using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_19_Tracker.Web.Models
{
	public class CasSuiviViewModel
	{
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string CIN { get; set; }
        public string Sexe { get; set; }
        public string NumeroTel { get; set; }
        public string Addresse { get; set; }
        public string Lien { get; set; }
        public string DateDernierCreation { get; set; }
        public string NiveauRisque { get; set; }
        public string DateFin { get; set; }
        public int NombreJours { get; set; }
        public bool Actif { get; set; }
    }
}
