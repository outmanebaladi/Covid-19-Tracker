using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_19_Tracker.Web.Models
{
	public class CasSuiviViewModel
	{
        public int Id { get; set; }
        [DisplayName("Nom")]
        public string Nom { get; set; }
        [DisplayName("Prenom")]

        public string Prenom { get; set; }
        [DisplayName("CIN")]

        public string CIN { get; set; }
        [DisplayName("Sexe")]

        public string Sexe { get; set; }
        [DisplayName("Numero de telephone")]

        public string NumeroTel { get; set; }
        [DisplayName("Code Postal")]
        public int CodePostal  { get; set; }
        [DisplayName("Region")]

        public string Region { get; set; }
        [DisplayName("Addresse")]

        public string Addresse { get; set; }
        [DisplayName("Lien")]

        public string Lien { get; set; }
        [DisplayName("Date de la derniere creation")]

        public string DateDernierCreation { get; set; }
        [DisplayName("Niveau de risque")]

        public string NiveauRisque { get; set; }
        [DisplayName("Date fin du suivi")]

        public string DateFin { get; set; }
        [DisplayName("Nombre de jours")]

        public int NombreJours { get; set; }
        [DisplayName("Actif")]

        public bool Actif { get; set; }
    }
}
