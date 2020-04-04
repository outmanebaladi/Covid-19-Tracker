using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_19_Tracker.Web.Models
{
	public class FicheSuiviViewModel
	{
        public int Id { get; set; }
        public string Date { get; set; }
        public int Temp_M { get; set; }
        public int Temp_S { get; set; }
        public bool Toux_M { get; set; }
        public bool Toux_S { get; set; }
        public bool MalDeGorge_M { get; set; }
        public bool MalDeGorge_S { get; set; }
        public bool Cephalee_M { get; set; }
        public bool Cephalee_S { get; set; }
        public bool Dyspnee_M { get; set; }
        public bool Dyspnee_S { get; set; }
        public bool Myalgie_M { get; set; }
        public bool Myalgie_S { get; set; }
        public string Autres_M { get; set; }
        public string Autres_S { get; set; }
        public string Conclusion_M { get; set; }
        public string Conclusion_S { get; set; }
    }
}
