using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    class Box1
    {//полета
        private double lenghtA;
        private double heightB;
        private double widthC;
        //конструктор
        public Box1(double lenght, double height, double width)
        {
            this.LenghtA = lenght;
            this.heightB = height;
            this.widthC = width;
        }

        //метод за валидация
        public double LenghtA
        {
            get { return lenghtA; }

            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Lenght can't be negaitve or zero");
                }
                lenghtA = value;
            }
        }
        
        //метод
        public double Obem()
        {
            return  lenghtA * heightB * widthC;
        }

        public double OkolnaObikolka()
        {
            return 2 * heightB * widthC + 2 * lenghtA * heightB;
        }

        public double PulnaObikolka()
        {
            return 2 * heightB * widthC + 2 * lenghtA * heightB+2*lenghtA*widthC;
        }



    }
}
