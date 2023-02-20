using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace naymaxia1
{
    public class Ploio
    {
        public List<Button> pedia;
        String name = "";
        public Ploio(List<Button> pedia, String name)
        {
            this.pedia = pedia;
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }

    }
}
