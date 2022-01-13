using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_KR_1
{
    public partial class UCFaultModeling : UserControl
    {
        private double TempFMAnswer;
        ProgramValues ProgramValuesObj = new ProgramValues();
        FaultModeling FaultModelingObj = new FaultModeling();
        UCCalcAttenuation UCCAObj = new UCCalcAttenuation();

        public UCFaultModeling()
        {
            InitializeComponent();
        }

        private void UCFMCalc_Click(object sender, EventArgs e)
        {
            double TempCalc = 0;
            UCFMSetAnswersCA();
            for (int i = 0; i < 16; i++)
            {
                TempCalc = UCCAObj.AnswerRequest(i, 0);
                ProgramValuesObj.GetPosition(i, 0);
                ProgramValuesObj.AnswerFMAccess = FaultModelingObj.CalcHor(TempCalc, ProgramValuesObj.TroubleFM[i, 0], false, false, false);
                TempFMAnswer = ProgramValuesObj.AnswerFMAccess;
                TempCalc = UCCAObj.AnswerRequest(i, 1);
                ProgramValuesObj.GetPosition(i, 1);
                ProgramValuesObj.AnswerFMAccess = FaultModelingObj.CalcVer(TempCalc, 0, 0, ProgramValuesObj.TroubleFM[i, 1]);
                TempFMAnswer += ProgramValuesObj.AnswerFMAccess;
                ProgramValuesObj.GetPosition(i, 2);
                ProgramValuesObj.AnswerFMAccess = TempFMAnswer;
            }
            UCFMSetAnswersFM();
        }

        private void UCFMSet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                CheckedValueHor(i);
                CheckedValueVer(i);
            }
            UCFMCalc.Enabled = true;
        }

        private void CheckedValueHor(int Floor)
        {
            switch (Floor)
            {
                case 0:
                    if (checkBoxH1.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
                case 1:
                    if (checkBoxH2.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
                case 2:
                    if (checkBoxH3.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
                case 3:
                    if (checkBoxH4.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
                case 4:
                    if (checkBoxH5.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
                case 5:
                    if (checkBoxH6.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
                case 6:
                    if (checkBoxH7.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
                case 7:
                    if (checkBoxH8.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
                case 8:
                    if (checkBoxH9.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
                case 9:
                    if (checkBoxH10.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
                case 10:
                    if (checkBoxH11.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
                case 11:
                    if (checkBoxH12.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
                case 12:
                    if (checkBoxH13.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
                case 13:
                    if (checkBoxH14.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
                case 14:
                    if (checkBoxH15.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
                case 15:
                    if (checkBoxH16.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 0] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 0] = false;
                    break;
            }
        }

        private void CheckedValueVer(int Floor)
        {
            switch (Floor)
            {
                case 0:
                    if (checkBoxV1.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
                case 1:
                    if (checkBoxV2.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
                case 2:
                    if (checkBoxV3.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
                case 3:
                    if (checkBoxV4.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
                case 4:
                    if (checkBoxV5.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
                case 5:
                    if (checkBoxV6.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
                case 6:
                    if (checkBoxV7.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
                case 7:
                    if (checkBoxV8.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
                case 8:
                    if (checkBoxV9.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
                case 9:
                    if (checkBoxV10.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
                case 10:
                    if (checkBoxV11.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
                case 11:
                    if (checkBoxV12.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
                case 12:
                    if (checkBoxV13.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
                case 13:
                    if (checkBoxV14.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
                case 14:
                    if (checkBoxV15.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
                case 15:
                    if (checkBoxV16.Checked == true)
                        ProgramValuesObj.TroubleFM[Floor, 1] = true;
                    else ProgramValuesObj.TroubleFM[Floor, 1] = false;
                    break;
            }
        }

        private void UCFMSetAnswersCA()
        {
            ProgramValuesObj.GetPosition(0, 0);
            LabelFloorHor1.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(0, 1);
            LabelFloorVert1.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(0, 2);
            LabelFloorTotal1.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(1, 0);
            LabelFloorHor2.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(1, 1);
            LabelFloorVert2.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(1, 2);
            LabelFloorTotal2.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(2, 0);
            LabelFloorHor3.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(2, 1);
            LabelFloorVert3.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(2, 2);
            LabelFloorTotal3.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(3, 0);
            LabelFloorHor4.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(3, 1);
            LabelFloorVert4.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(3, 2);
            LabelFloorTotal4.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(4, 0);
            LabelFloorHor5.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(4, 1);
            LabelFloorVert5.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(4, 2);
            LabelFloorTotal5.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(5, 0);
            LabelFloorHor6.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(5, 1);
            LabelFloorVert6.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(5, 2);
            LabelFloorTotal6.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(6, 0);
            LabelFloorHor7.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(6, 1);
            LabelFloorVert7.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(6, 2);
            LabelFloorTotal7.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(7, 0);
            LabelFloorHor8.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(7, 1);
            LabelFloorVert8.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(7, 2);
            LabelFloorTotal8.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(8, 0);
            LabelFloorHor9.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(8, 1);
            LabelFloorVert9.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(8, 2);
            LabelFloorTotal9.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(9, 0);
            LabelFloorHor10.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(9, 1);
            LabelFloorVert10.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(9, 2);
            LabelFloorTotal10.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(10, 0);
            LabelFloorHor11.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(10, 1);
            LabelFloorVert11.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(10, 2);
            LabelFloorTotal11.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(11, 0);
            LabelFloorHor12.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(11, 1);
            LabelFloorVert12.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(11, 2);
            LabelFloorTotal12.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(12, 0);
            LabelFloorHor13.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(12, 1);
            LabelFloorVert13.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(12, 2);
            LabelFloorTotal13.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(13, 0);
            LabelFloorHor14.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(13, 1);
            LabelFloorVert14.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(13, 2);
            LabelFloorTotal14.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(14, 0);
            LabelFloorHor15.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(14, 1);
            LabelFloorVert15.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(14, 2);
            LabelFloorTotal15.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(15, 0);
            LabelFloorHor16.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(15, 1);
            LabelFloorVert16.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
            ProgramValuesObj.GetPosition(15, 2);
            LabelFloorTotal16.Text = Convert.ToString(ProgramValuesObj.AnswerAccess);
        }

        private void UCFMSetAnswersFM()
        {
            ProgramValuesObj.GetPosition(0, 0);
            FMLabelFloorHor1.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(0, 1);
            FMLabelFloorVert1.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(0, 2);
            FMLabelFloorTotal1.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(1, 0);
            FMLabelFloorHor2.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(1, 1);
            FMLabelFloorVert2.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(1, 2);
            FMLabelFloorTotal2.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(2, 0);
            FMLabelFloorHor3.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(2, 1);
            FMLabelFloorVert3.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(2, 2);
            FMLabelFloorTotal3.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(3, 0);
            FMLabelFloorHor4.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(3, 1);
            FMLabelFloorVert4.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(3, 2);
            FMLabelFloorTotal4.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(4, 0);
            FMLabelFloorHor5.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(4, 1);
            FMLabelFloorVert5.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(4, 2);
            FMLabelFloorTotal5.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(5, 0);
            FMLabelFloorHor6.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(5, 1);
            FMLabelFloorVert6.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(5, 2);
            FMLabelFloorTotal6.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(6, 0);
            FMLabelFloorHor7.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(6, 1);
            FMLabelFloorVert7.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(6, 2);
            FMLabelFloorTotal7.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(7, 0);
            FMLabelFloorHor8.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(7, 1);
            FMLabelFloorVert8.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(7, 2);
            FMLabelFloorTotal8.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(8, 0);
            FMLabelFloorHor9.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(8, 1);
            FMLabelFloorVert9.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(8, 2);
            FMLabelFloorTotal9.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(9, 0);
            FMLabelFloorHor10.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(9, 1);
            FMLabelFloorVert10.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(9, 2);
            FMLabelFloorTotal10.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(10, 0);
            FMLabelFloorHor11.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(10, 1);
            FMLabelFloorVert11.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(10, 2);
            FMLabelFloorTotal11.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(11, 0);
            FMLabelFloorHor12.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(11, 1);
            FMLabelFloorVert12.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(11, 2);
            FMLabelFloorTotal12.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(12, 0);
            FMLabelFloorHor13.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(12, 1);
            FMLabelFloorVert13.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(12, 2);
            FMLabelFloorTotal13.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(13, 0);
            FMLabelFloorHor14.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(13, 1);
            FMLabelFloorVert14.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(13, 2);
            FMLabelFloorTotal14.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(14, 0);
            FMLabelFloorHor15.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(14, 1);
            FMLabelFloorVert15.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(14, 2);
            FMLabelFloorTotal15.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(15, 0);
            FMLabelFloorHor16.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(15, 1);
            FMLabelFloorVert16.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
            ProgramValuesObj.GetPosition(15, 2);
            FMLabelFloorTotal16.Text = Convert.ToString(ProgramValuesObj.AnswerFMAccess);
        }
    }
}
