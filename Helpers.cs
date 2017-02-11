using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sumo
{
    class Helpers
    {
        public static bool IsOpperant(string act,ref EOpperationType operand)
        {
            bool result = false;

            if (act == "+")
            {
                result = true;
                operand = EOpperationType.Add;
            }
            else if (act == "-")
            {
                result = true;
                operand = EOpperationType.Diff;
            }

            else if (act == "/")
            {
                result = true;
                operand = EOpperationType.Div;
            }
            else if (act == "*")
            {
                result = true;
                operand = EOpperationType.Mult;
            }


            return result;
        }

        public static double GetSolved(double dLeft, double dRight, EOpperationType opperatorType)
        {
            double result = 0;

            switch (opperatorType)
            {
                case (EOpperationType.Add):

                    result = dLeft + dRight;
                    break;

                case (EOpperationType.Diff):
                    result = dLeft - dRight;
                    break;

                case (EOpperationType.Div):
                    result = dLeft / dRight;
                    break;

                case (EOpperationType.Mult):
                    result = dLeft * dRight;
                    break;

                case (EOpperationType.Random):
                    result = dLeft + dRight;
                    break;

            }

            return result;
        }


    }
}
