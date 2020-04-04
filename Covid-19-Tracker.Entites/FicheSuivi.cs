using System;

namespace Covid_19_Tracker.Entites
{
    public class FicheSuivi : IEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
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
        public CasSuivi CasSuivi { get; set; }
    }
}
