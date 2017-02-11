using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sumo
{
    class Runda
    {
        public Runda() { }

        private DateTime start;
        private DateTime stop;

        private List<Equation> equations = new List<Equation>();

        public void Add(string equastion, string solve)
        {
            Equation eq = new Equation(equastion, solve);
            if (eq.IsSolved)
            {
                solvedCount++;
            }
            else if (!eq.IsCorrect)
            {
                unknowEq++;
            }
            else
            {
                badCount++;
            }
            equations.Add(eq);
        }

        public void SaveToFile(string FilePath)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Equation eq in this.equations)
            {

            }
        }




        public int solvedCount { get; set; }

        public int unknowEq { get; set; }

        public int badCount { get; set; }
    }

    public enum EGameType
    {
        NoLimit,
        ForTime,
        Rounds
    }

    public enum EOpperationType
    {
        Add,
        Diff,
        Mult,
        Div,
        Random

    }


    
}
