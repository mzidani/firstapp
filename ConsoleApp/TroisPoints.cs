using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class TroisPoints
    {
        public Point Premier { get; set; }
        public Point Deuxieme { get; set; }
        public Point Troisieme { get; set; }

        public TroisPoints(Point premier, Point deuxieme, Point troisieme)
        {
            this.Premier = premier;
            this.Deuxieme = deuxieme;
            this.Troisieme = troisieme;
        }

        public bool TesterAlignement()
        {
            double ab = this.Premier.CalculerDistance(this.Troisieme) + this.Deuxieme.CalculerDistance(this.Troisieme);
            double ac = this.Premier.CalculerDistance(this.Deuxieme) + this.Deuxieme.CalculerDistance(this.Troisieme);
            double bc = this.Premier.CalculerDistance(this.Troisieme) + this.Premier.CalculerDistance(this.Deuxieme);
            if(this.Premier.CalculerDistance(this.Deuxieme) == ab || this.Premier.CalculerDistance(this.Troisieme) == ac || this.Deuxieme.CalculerDistance(this.Troisieme) == bc)
            {
                return true;
            }
            return false;
        }

        public bool EstIsocele()
        {
            double ab = this.Premier.CalculerDistance(this.Troisieme) + this.Deuxieme.CalculerDistance(this.Troisieme);
            double ac = this.Premier.CalculerDistance(this.Deuxieme) + this.Deuxieme.CalculerDistance(this.Troisieme);
            double bc = this.Premier.CalculerDistance(this.Troisieme) + this.Premier.CalculerDistance(this.Deuxieme);
            if (ab == ac || ab == bc || bc == ac)
            {
                return true;
            }
            return false;
        }
    }
}
