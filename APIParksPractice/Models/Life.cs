using System;
using System.Collections.Generic;

namespace APIParksPractice.models
{
    public partial class Life
    {
       
        public int Id { get; set; }
        public int FemaleLifeExpectancy { get; set; }
        public int MaleLifeExpectancy { get; set; }
        public int FemaleSmoker { get; set; }
        public int MaleSmoker { get; set; }
        public int FemaleDrinker { get; set; }
        public int MaleDrinker { get; set; }
        public int FemaleBoth { get; set; }
        public int MaleBoth { get; set; }
    }
}
