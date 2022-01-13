using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_KR_1
{
    class ProgramValues
    {
        public int[] LengthHC = new int[16];    //Длина горизонтальной линии
        public double[] LengthVС = new double[16];  //Длина вертикальной линии
        public int[] CountC = new int[16];      //Количество пар коннекторов
        public int[] CountM = new int[16];      //Количество муфт
        public bool[] Trouble1 = new bool[16];  //Удаление 30 см оболочки кабеля
        public bool[] Trouble2 = new bool[16];  //Развитие пар кабеля на 5 см
        public bool[] Trouble3 = new bool[16];  //Развитие пар кабеля на 15 см
        public bool[] Trouble4 = new bool[16];  //Скручивание кабеля с радиусом изгиба 3,5 см
        public bool[,] TroubleFM = new bool[16, 2];     //Массив с данными моделирования повреждений
        static private double[,] Answer = new double[16, 3];   //Массив, хранящий данные о расчётах
        static private double[,] AnswerFM = new double[16, 3];     //Массив, хранящий данные о расчётах с учётом устранения повреждений
        private int x, y;

        protected internal void GetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double AnswerAccess
        {
            get { return Answer[x, y]; }
            protected internal set { Answer[x, y] = value; }
        }

        public double AnswerFMAccess
        {
            get { return AnswerFM[x, y]; }
            protected internal set { AnswerFM[x, y] = value; }
        }
    }
}
