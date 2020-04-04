using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_19_Tracker.Web.Models
{
	public class CasPositifViewModel
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
        [DisplayName("Region")]
        public string Region { get; set; }
        [DisplayName("Addresse")]
        public string Addresse { get; set; }
        [DisplayName("Code Postal")]
        public string CodePostal { get; set; }
        [DisplayName("Numero de telephone")]
        public string NumeroTel { get; set; }
        [DisplayName("Type")]
        public string Type { get; set; }
        [DisplayName("Date de declaration")]
        public string Date_Declaration { get; set; }
        [DisplayName("Date du dernier contact")]
        public string Date_Dernier_Contact { get; set; }
        [DisplayName("Nombre de contacts")]
        public int Nombre_Contacts { get; set; }
    }
}
