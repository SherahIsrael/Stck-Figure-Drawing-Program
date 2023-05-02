using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stck_Figure_Drawing_Program
{
    internal class StickFigureDimensions
    {
        private readonly int Yvalue;

        public StickFigureDimensions(int mouseY, int mouseY1)
        {
            BaseUnit = (mouseY1 - mouseY) / 10;
            Yvalue = mouseY;
        }

        public int BaseUnit { get; }

        //Gets the dimensions for each part of the stick people

        public int HeadDiameter
        {
            get { return BaseUnit * 3; }
        }

        public int HeadRadius
        {
            get { return (BaseUnit * 3) / 2; }
        }

        public int BodySize
        {
            get { return BaseUnit * 4; }
        }

        public int MidBody
        {
            get { return Yvalue + BaseUnit * 5; }
        }

        public int LegSize
        {
            get { return BaseUnit * 3;}
        }
    }
}
