//MIT, 2017, WinterDev
//MIT, 2014, PouletFrit
//MIT, 2009, Alan Shaw
using System.Collections.Generic;

namespace CsDelaunay
{

    public class Triangle
    {

        private List<Site> sites;
        public List<Site> Sites { get { return sites; } }

        public Triangle(Site a, Site b, Site c)
        {
            sites = new List<Site>();
            sites.Add(a);
            sites.Add(b);
            sites.Add(c);
        }

        public void Dispose()
        {
            sites.Clear();
        }
    }
}