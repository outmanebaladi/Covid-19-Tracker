using System;
using System.ComponentModel;

namespace Covid_19_Tracker.Web.Mappers.ExcelExport
{
    public class ExcelSuivi
    {
        [DisplayName("Numero")]
        public string Id { get; set; }
        [DisplayName("Nom et Prenom")]
        public string NomPrenom { get; set; }
        [DisplayName("Date")]
        public DateTime DateSuivi { get; set; }
        [DisplayName("Temperature_M")]
        public int Temperature_M { get; set; }
        [DisplayName("Temperature_S")]
        public int Temperature_S { get; set; }
        [DisplayName("Toux_M")]
        public string Toux_M { get; set; }
        [DisplayName("Toux_S")]
        public string Toux_S { get; set; }
        [DisplayName("Dyspnee_M")]
        public string Dyspnee_M { get; set; }
        [DisplayName("Dyspnee_S")]
        public string Dyspnee_S { get; set; }
        [DisplayName("MalAGorge_M")]
        public string MalAGorge_M { get; set; }
        [DisplayName("MalAGorge_S")]
        public string MalAGorge_S { get; set; }
        [DisplayName("Cephale_M")]
        public string Cephale_M { get; set; }
        [DisplayName("Cephale_S")]
        public string Cephale_S { get; set; }
        [DisplayName("Myalgi_M")]
        public string Myalgi_M { get; set; }
        [DisplayName("Myalgi_S")]
        public string Myalgi_S { get; set; }
        [DisplayName("Aute1_M")]
        public string Aute1_M { get; set; }
        [DisplayName("Autre1_S")]
        public string Autre1_S { get; set; }
        [DisplayName("Conclusion_M")]
        public string Conclusion_M { get; set; }
        [DisplayName("Conclusion_S")]
        public string Conclusion_S { get; set; }
    }
}
