using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sumo
{
    class Equation
    {
        public string Content { get; set; }

        public string Solve { get; set; }

        private bool isSolved = false;
        public bool IsSolved { get {return isSolved;} }

        private bool isCorrect = false;
        public bool IsCorrect { get { return isCorrect; } }


        private int duration = 0;
        public int Duration { get {return duration;} }

        private double goodSolved = 0;
        public double GoodSolved { get { return goodSolved; } }  
        
        public Equation() { }
        public Equation(string Equation, string Solve)
        {
            this.Content = Equation;
            this.Solve = Solve;

            checkSolve();
        }

        private bool checkSolve()
        {
            double dSolve = 0;
            double _solve = -1;
            bool isDouble = double.TryParse(this.Solve, out dSolve);

            this.isSolved = false;
            this.isCorrect = false;

            if (!isDouble)
            {
                return this.isCorrect;
            }

            string[] seq = this.Content.Split(' ');

            if (seq.Length == 3)
            {
                string left = seq[0].Trim();
                string act = seq[1].Trim();
                string right = seq[2].Trim();

                EOpperationType opperand = EOpperationType.Add;

                double dLeft = 0;
                double dRight = 0;

                if (!double.TryParse(left, out dLeft))
                {
                    return this.isCorrect;
                }

                if (!double.TryParse(right, out dRight))
                {
                    return this.isCorrect;
                }

                if (!Helpers.IsOpperant(act,ref opperand))
                {
                    
                    return this.isCorrect;
                }

                _solve = Helpers.GetSolved(dLeft, dRight, opperand); 

                this.goodSolved = _solve;
            }

            this.isSolved = (dSolve == _solve);
            this.isCorrect = true;

            return isSolved;
        }



    }
}
