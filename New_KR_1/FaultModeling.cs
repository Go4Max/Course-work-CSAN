using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_KR_1
{
    class FaultModeling : CalcAttenuation
    {
        public override double CalcHor(double x, bool t1, bool t2, bool t3, bool t4)
        {
            if (t1 == true)
                AnsHVA = x + 0.75;
            else AnsHVA = x;
            return AnsHVA;
        }

        public override double CalcVer(double l, int cc, int cm, bool t)
        {
            if (t == true)
                AnsHVA = l + 0.3;
            else AnsHVA = l;
            return AnsHVA;
        }
    }
}
