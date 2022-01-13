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
    public partial class UCCalcAttenuation : UserControl
    {
        private int Floor;
        private double TempAnswer1, TempAnswer2;
        private int[] Trouble = new int[16];
        ProgramValues ProgramValuesObj = new ProgramValues();

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e) //Кнопка выбора этажа
        {
            Floor = int.Parse(comboBox1.Text);
            Floor--;
            SValue();
        }
        
        public UCCalcAttenuation()
        {
            InitializeComponent();
        }

        private bool CheckedT1          //Удаление 30 см оболочки кабеля на станционном конце
        {
            get { return Trouble1.Checked; }
            set { Trouble1.Checked = value; }
        }
        private bool CheckedT2          //Развитие пар кабеля 5 см на станционном конце
        {
            get { return Trouble2.Checked; }
            set { Trouble2.Checked = value; }
        }
        private bool CheckedT3          //Развитие пар кабеля 15 см на станционном конце
        {
            get { return Trouble3.Checked; }
            set { Trouble3.Checked = value; }
        }
        private bool CheckedT4          //Скручивание кабеля с радиусом изгиба 3,5 см
        {
            get { return Trouble4.Checked; }
            set { Trouble4.Checked = value; }
        }

        private void UCCASet_Click(object sender, EventArgs e)  //Кнопка установки значений этажа
        {
            RValue();
            switch (Floor)
            {
                case 0:
                    checkBox1.Checked = true;
                    break;
                case 1:
                    checkBox2.Checked = true;
                    break;
                case 2:
                    checkBox3.Checked = true;
                    break;
                case 3:
                    checkBox4.Checked = true;
                    break;
                case 4:
                    checkBox5.Checked = true;
                    break;
                case 5:
                    checkBox6.Checked = true;
                    break;
                case 6:
                    checkBox7.Checked = true;
                    break;
                case 7:
                    checkBox8.Checked = true;
                    break;
                case 8:
                    checkBox9.Checked = true;
                    break;
                case 9:
                    checkBox10.Checked = true;
                    break;
                case 10:
                    checkBox11.Checked = true;
                    break;
                case 11:
                    checkBox12.Checked = true;
                    break;
                case 12:
                    checkBox13.Checked = true;
                    break;
                case 13:
                    checkBox14.Checked = true;
                    break;
                case 14:
                    checkBox15.Checked = true;
                    break;
                case 15:
                    checkBox16.Checked = true;
                    break;
            }
        }

        private void UCCACalc_Click(object sender, EventArgs e) //Кнопка расчёта
        {
            ProgramValuesObj.LengthVС[0] = 2.8 + 2.8 * 15 / 100;
            for (int i = 1; i < 16; i++)
                ProgramValuesObj.LengthVС[i] = ProgramValuesObj.LengthVС[i - 1] + 2.8 + 2.8 * 15 / 100;
            CalcAttenuation CalcAttenuationObj = new CalcAttenuation();
            for (int i = 0; i < 16; i++)
            {
                ProgramValuesObj.GetPosition(i, 0);
                ProgramValuesObj.AnswerAccess = CalcAttenuationObj.CalcHor(ProgramValuesObj.LengthHC[i], ProgramValuesObj.Trouble1[i], ProgramValuesObj.Trouble2[i], ProgramValuesObj.Trouble3[i], ProgramValuesObj.Trouble4[i]);
                ProgramValuesObj.GetPosition(i, 1);
                ProgramValuesObj.AnswerAccess = CalcAttenuationObj.CalcVer(ProgramValuesObj.LengthVС[i], ProgramValuesObj.CountC[i], ProgramValuesObj.CountM[i], false);
                ProgramValuesObj.GetPosition(i, 0);
                TempAnswer1 = ProgramValuesObj.AnswerAccess;
                ProgramValuesObj.GetPosition(i, 1);
                TempAnswer2 = ProgramValuesObj.AnswerAccess;
                ProgramValuesObj.GetPosition(i, 2);
                ProgramValuesObj.AnswerAccess = CalcAttenuationObj.CalcAll(TempAnswer1, TempAnswer2);
            }
            UCCASetAnswers();
        }

        private void UCCAClear_Click(object sender, EventArgs e)    //Кнопка очистки всех значений
        {
            for (int i = 0; i < 16; i++)
            {
                SetCheckedFalse(i);
                ProgramValuesObj.LengthHC[i] = ProgramValuesObj.CountM[i] = ProgramValuesObj.CountC[i] = 1;
                ProgramValuesObj.Trouble1[i] = ProgramValuesObj.Trouble2[i] = ProgramValuesObj.Trouble3[i] = ProgramValuesObj.Trouble4[i] = false;
            }
        }

        private void UCCAClearFloor_Click(object sender, EventArgs e)   //Кнопка очистки всех значений текущего этажа
        {
            SetCheckedFalse(Floor);
            ProgramValuesObj.LengthHC[Floor] = ProgramValuesObj.CountM[Floor] = ProgramValuesObj.CountC[Floor] = 1;
            ProgramValuesObj.Trouble1[Floor] = ProgramValuesObj.Trouble2[Floor] = ProgramValuesObj.Trouble3[Floor] = ProgramValuesObj.Trouble4[Floor] = false;
        }

        private void SetCheckedFalse(int Floor)     //Обнуление полей вывода
        {
            switch (Floor)
            {
                case 0:
                    checkBox1.Checked = false;
                    LabelFloorHor1.Text = LabelFloorVert1.Text = LabelFloorTotal1.Text = "-";
                    break;
                case 1:
                    checkBox2.Checked = false;
                    LabelFloorHor2.Text = LabelFloorVert2.Text = LabelFloorTotal2.Text = "-";
                    break;
                case 2:
                    checkBox3.Checked = false;
                    LabelFloorHor3.Text = LabelFloorVert3.Text = LabelFloorTotal3.Text = "-";
                    break;
                case 3:
                    checkBox4.Checked = false;
                    LabelFloorHor4.Text = LabelFloorVert4.Text = LabelFloorTotal4.Text = "-";
                    break;
                case 4:
                    checkBox5.Checked = false;
                    LabelFloorHor5.Text = LabelFloorVert5.Text = LabelFloorTotal5.Text = "-";
                    break;
                case 5:
                    checkBox6.Checked = false;
                    LabelFloorHor6.Text = LabelFloorVert6.Text = LabelFloorTotal6.Text = "-";
                    break;
                case 6:
                    checkBox7.Checked = false;
                    LabelFloorHor7.Text = LabelFloorVert7.Text = LabelFloorTotal7.Text = "-";
                    break;
                case 7:
                    checkBox8.Checked = false;
                    LabelFloorHor8.Text = LabelFloorVert8.Text = LabelFloorTotal8.Text = "-";
                    break;
                case 8:
                    checkBox9.Checked = false;
                    LabelFloorHor9.Text = LabelFloorVert9.Text = LabelFloorTotal9.Text = "-";
                    break;
                case 9:
                    checkBox10.Checked = false;
                    LabelFloorHor10.Text = LabelFloorVert10.Text = LabelFloorTotal10.Text = "-";
                    break;
                case 10:
                    checkBox11.Checked = false;
                    LabelFloorHor11.Text = LabelFloorVert11.Text = LabelFloorTotal11.Text = "-";
                    break;
                case 11:
                    checkBox12.Checked = false;
                    LabelFloorHor12.Text = LabelFloorVert12.Text = LabelFloorTotal12.Text = "-";
                    break;
                case 12:
                    checkBox13.Checked = false;
                    LabelFloorHor13.Text = LabelFloorVert13.Text = LabelFloorTotal13.Text = "-";
                    break;
                case 13:
                    checkBox14.Checked = false;
                    LabelFloorHor14.Text = LabelFloorVert14.Text = LabelFloorTotal14.Text = "-";
                    break;
                case 14:
                    checkBox15.Checked = false;
                    LabelFloorHor15.Text = LabelFloorVert15.Text = LabelFloorTotal15.Text = "-";
                    break;
                case 15:
                    checkBox16.Checked = false;
                    LabelFloorHor16.Text = LabelFloorVert16.Text = LabelFloorTotal16.Text = "-";
                    break;
            }
        }

        public void RValue() //Задание значений
        {
            ProgramValuesObj.LengthHC[Floor] = int.Parse(numericUpDown1.Text);
            ProgramValuesObj.CountC[Floor] = int.Parse(numericUpDown2.Text);
            ProgramValuesObj.CountM[Floor] = int.Parse(numericUpDown3.Text);
            if (CheckedT1 == true)
                ProgramValuesObj.Trouble1[Floor] = true;
            if (CheckedT2 == true)
                ProgramValuesObj.Trouble2[Floor] = true;
            if (CheckedT3 == true)
                ProgramValuesObj.Trouble3[Floor] = true;
            if (CheckedT4 == true)
                ProgramValuesObj.Trouble4[Floor] = true;
        }

        public void SValue() //Установка значений содержащихся в массивах
        {
            numericUpDown1.Text = Convert.ToString(ProgramValuesObj.LengthHC[Floor]);
            numericUpDown2.Text = Convert.ToString(ProgramValuesObj.CountC[Floor]);
            numericUpDown3.Text = Convert.ToString(ProgramValuesObj.CountM[Floor]);
            if (ProgramValuesObj.Trouble1[Floor] == true)
                CheckedT1 = true;
            else CheckedT1 = false;
            if (ProgramValuesObj.Trouble2[Floor] == true)
                CheckedT2 = true;
            else CheckedT2 = false;
            if (ProgramValuesObj.Trouble3[Floor] == true)
                CheckedT3 = true;
            else CheckedT3 = false;
            if (ProgramValuesObj.Trouble4[Floor] == true)
                CheckedT4 = true;
            else CheckedT4 = false;

        }

        protected internal double AnswerRequest(int x, int y)
        {
            ProgramValuesObj.GetPosition(x, y);
            return ProgramValuesObj.AnswerAccess;
        }

        private void UCCASetAnswers()
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
    }
}
