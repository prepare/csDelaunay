﻿//MIT, 2017, WinterDev
//MIT, 2014, PouletFrit
namespace CsDelaunay
{

    public class LR
    {

        public static readonly LR LEFT = new LR("left");
        public static readonly LR RIGHT = new LR("right");

        private string name;

        private LR(string name)
        {
            this.name = name;
        }

        public static LR Other(LR leftRight)
        {
            return leftRight == LEFT ? RIGHT : LEFT;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
