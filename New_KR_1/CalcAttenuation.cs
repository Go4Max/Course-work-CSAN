using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_KR_1
{
    class CalcAttenuation
    {
        const int f = 125;
        public double AnsHVA { get; set; }
        private double TempVal1, TempVal2, TempVal3;

        public virtual double CalcHor(double x, bool t1, bool t2, bool t3, bool t4)
        {
            CalcAnswer(x);
            AnsHVA = Math.Round(TempVal1 * Math.Pow(f, 1.0 / 2.0) + TempVal2 * f + TempVal3 / Math.Pow(f, 1.0 / 2.0), 2);
            if (t1 == true)
                AnsHVA += 2;
            if (t2 == true)
                AnsHVA += 3.8;
            if (t3 == true)
                AnsHVA += 11.6;
            if (t4 == true)
                AnsHVA += 1.9;
            return AnsHVA;
        }

        public virtual double CalcVer(double l, int cc, int cm, bool t)
        {
            l = l / 1000;
            AnsHVA = Math.Round(Math.Cos(l) * Math.Sin(l) * l + 0.75 * cc + 0.3 * cm, 2);
            return AnsHVA;
        }

        public double CalcAll(double ch, double cv)
        {
            AnsHVA = ch + cv;
            return AnsHVA;
        }

        private void CalcAnswer(double x)
        {
            TempVal1 = Math.Abs(1 / (Math.Pow(1 + x, 1.0 / 2.0)) - 1 / Math.Exp(x));
            TempVal2 = Math.Abs(Math.Cos(x) + Math.Log(Math.Pow(x, 4)));
            TempVal3 = Math.Abs(Math.Pow(Math.Cos(x), 2) * Math.Sin(x));
        }
    }
}
