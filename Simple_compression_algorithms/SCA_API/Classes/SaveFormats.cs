using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA_API.Classes
{
    public static class SaveFormats
    {
        private static List<CITypeFormat> _ciTFs = new List<CITypeFormat>()
        {
            new CITypeFormat("P5",".pgm"),
            new CITypeFormat("P6",".ppm")
        };

        public static CITypeFormat GetCITF(string fileName)
        {
            CITypeFormat citfSelected = null;
            foreach (var citf in _ciTFs)
                if (fileName.Contains(citf.Format))
                    citfSelected = citf;
            return citfSelected;
        }
    }
}
