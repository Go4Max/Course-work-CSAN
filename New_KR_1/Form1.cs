using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_KR_1
{
    public partial class Form1 : Form
    {
        static Form1 _obj;

        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel pnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
        }

        private void buttonExit_Click(object sender, EventArgs e)   //Кнопка закрытия программы
        {
            Close();
        }

        private void buttonCalcAttenuation_Click(object sender, EventArgs e)    //Кнопка переключения программы в режим расчёта затуханий сети
        {
            UCCalcAttenuation ucCA = new UCCalcAttenuation();
            ucCA.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucCA);
            buttonCalcAttenuation.BackColor = System.Drawing.Color.DarkKhaki;
            buttonCalcAttenuation.ForeColor = System.Drawing.Color.Sienna;
            buttonFaultModeling.BackColor = System.Drawing.Color.Wheat;
            buttonFaultModeling.ForeColor = System.Drawing.Color.Chocolate;
            panelContainer.Controls["UCCalcAttenuation"].BringToFront();
        }

        private void buttonFaultModeling_Click(object sender, EventArgs e)  //Кнопка переключения программы в режим расчёта моделирования повреждений сети
        {
            UCFaultModeling ucFM = new UCFaultModeling();
            ucFM.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucFM);
            buttonCalcAttenuation.BackColor = System.Drawing.Color.Wheat;
            buttonCalcAttenuation.ForeColor = System.Drawing.Color.Chocolate;
            buttonFaultModeling.BackColor = System.Drawing.Color.DarkKhaki;
            buttonFaultModeling.ForeColor = System.Drawing.Color.Sienna;
            panelContainer.Controls["UCFaultModeling"].BringToFront();
        }
    }
}
