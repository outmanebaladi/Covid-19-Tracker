﻿namespace Covid_19_Tracker.Entites
{
    public class FicheSuivi : IEntity
    {
        public int Id { get; set; }
        public int Temp_M { get; set; }
        public int Temp_S { get; set; }
        public bool Toux_M { get; set; }
        public bool Toux_S { get; set; }
        public CasSuivi casSuivi { get; set; }
    }
}
